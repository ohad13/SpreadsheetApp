using Microsoft.VisualBasic.FileIO;
using SpreadsheetApp;
using System;
using System.IO;
using System.Threading;

class ShareableSpreadSheet
{
    private Cell[,] sheet;
    private int _row;
    private int _col;

    private static Boolean _searchLimit = false;// Will changed to true if some thread calls the "setConcurrentSearchLimit"(limit number of searchers).
    private static SemaphoreSlim slimSearch;// Semapore that will be limited to the number of serachers "nUsers".
    private static int semaphoreCount;// Used to know how many we can search at maximum in parallel(in the four search functions).
    private static Semaphore lockAddExcange = new Semaphore(1, 1); //Lock add/exchange operations and getSize operation.- just one operation from those will work in parallel.
    private static Mutex saveM = new Mutex();// Lock save function to avoid suplicated names - synchronize "cnt".
    private static Mutex concurrent = new Mutex(); // Used to make sure we finish first the limited number of searchers we received before we accept new number
    private static Semaphore readCnt = new Semaphore(1, 1);// Used to synchronize the 'read' attribute, that holds how many readers are in the spreedsheet now. 
    private static int read = 0;// counter holds how many readers are in the spreedsheet now. 
    private static int cnt = 0;// Counter to the file's name we'll save

    public ShareableSpreadSheet(int nRows, int nCols)
    {
        // construct a nRows*nCols spreadsheet
        sheet = new Cell[nRows, nCols];
        this._row = nRows;
        this._col = nCols;
        for (int i = 0; i < _row; i++)
        {
            for (int j = 0; j < _col; j++)
            {
                sheet[i, j] = new Cell("testcell" + (i + 1) + (j + 1));
            }
        }
        semaphoreCount = 1000;
        slimSearch = new SemaphoreSlim(0, semaphoreCount);
    }

    public String getCell(int row, int col)
    {
        // return the string in the cell [row,col]
        row--;
        col--;
        readCnt.WaitOne();
        read++;
        if (read == 1)
            lockAddExcange.WaitOne();
        readCnt.Release();
        if (boundary(row, col))
        {
            string s = sheet[row, col].getStr();
            readCnt.WaitOne();
            read--;
            if (read == 0)
                lockAddExcange.Release();
            readCnt.Release();
            return s;
        }
        readCnt.WaitOne();
        read--;
        if (read == 0)
            lockAddExcange.Release();
        readCnt.Release();
        return null;
    }

    public void getSize(ref int nRows, ref int nCols)
    {
        // return the size of the spreadsheet of nRows, nCols
        lockAddExcange.WaitOne();
        nRows = _row;
        nCols = _col;
        lockAddExcange.Release();
    }

    public bool setCell(int row, int col, String str)
    {
        // set the string at [row,col]
        row--;
        col--;
        lockAddExcange.WaitOne();
        if (boundary(row, col))
        {
            sheet[row, col].setStr(str);
            lockAddExcange.Release();
            return true;
        }
        lockAddExcange.Release();
        return false;
    }

    public bool exchangeRows(int row1, int row2)
    {
        row1--;
        row2--;
        lockAddExcange.WaitOne();
        // exchange the content of row1 and row2
        if (boundary(row1, 0) && boundary(row2, 0))
        {
            try
            {
                string[] tmp = new string[_col];
                for (int i = 0; i < _col; i++)//will use in temporary string[]
                {
                    string str = sheet[row1, i].getStr();
                    tmp.SetValue(str, i); //SetValue(string to insert, index to insert to)
                    sheet[row1, i].setStr(sheet[row2, i].getStr());
                }
                for (int i = 0; i < _col; i++)
                {
                    sheet[row2, i].setStr(tmp[i]);
                }
            }
            catch (Exception e) { }
            lockAddExcange.Release();
            return true;
        }
        lockAddExcange.Release();
        return false;
    }

    public bool exchangeCols(int col1, int col2)
    {
        col1--;
        col2--;
        lockAddExcange.WaitOne();
        // exchange the content between col1 and col2
        if (boundary(0, col1) && boundary(0, col2))
        {
            try
            {
                string[] tmp = new string[_row];
                for (int i = 0; i < _row; i++)
                {
                    tmp.SetValue(sheet[i, col1].getStr(), i);
                    sheet[i, col1].setStr(sheet[i, col2].getStr());
                }
                for (int i = 0; i < _row; i++)
                {
                    sheet[i, col2].setStr(tmp[i]);
                }
            }
            catch (Exception e) { }
            lockAddExcange.Release();
            return true;
        }
        lockAddExcange.Release();
        return false;
    }

    public bool addRow(int row1)
    {
        //add a row after row1
        lockAddExcange.WaitOne();
        if (boundary(row1 - 1, 0))
        {
            try
            {
                Cell[,] update = new Cell[_row + 1, _col];
                for (int i = 0; i < row1; i++)
                {
                    for (int j = 0; j < _col; j++)
                    {
                        update[i, j] = sheet[i, j];
                    }
                }
                for (int i = 0; i < _col; i++)
                {
                    update[row1, i] = new Cell("");
                }
                for (int i = 0; i < _row - row1; i++)
                {
                    for (int j = 0; j < _col; j++)
                    {
                        update[i + row1 + 1, j] = sheet[i + row1, j];
                    }
                }
                _row++;
                sheet = update;
            }
            catch (Exception e) { }
            lockAddExcange.Release();
            return true;
        }
        lockAddExcange.Release();
        return false;
    }

    public bool addCol(int col1)
    {
        //add a column after col1
        lockAddExcange.WaitOne();
        if (boundary(0, col1 - 1))
        {
            try
            {
                Cell[,] update = new Cell[_row, _col + 1];
                for (int i = 0; i < _row; i++)
                {
                    for (int j = 0; j < col1; j++)
                    {
                        update[i, j] = sheet[i, j];
                    }
                }
                for (int i = 0; i < _row; i++)
                {
                    update[i, col1] = new Cell("");
                }
                for (int i = 0; i < _row; i++)
                {
                    for (int j = 0; j < _col - col1; j++)
                    {
                        update[i, j + 1 + col1] = sheet[i, j + col1];
                    }
                }
                _col++;
                sheet = update;
            }
            catch (Exception e) { }
            lockAddExcange.Release();
            return true;
        }
        lockAddExcange.Release();
        return false;
    }

    public bool searchInRow(int row, String str, ref int col)
    {
        // perform search in specific row
        readCnt.WaitOne();
        read++;
        if (read == 1)
            lockAddExcange.WaitOne();
        readCnt.Release();
        if (_searchLimit)
            slimSearch.Wait();
        if (boundary(row - 1, 0))
        {
            for (int i = 0; i < _col; i++)
            {
                try
                {
                    if (sheet[row - 1, i].getStr().Equals(str))
                    {
                        col = i + 1;
                        if (_searchLimit)
                            slimSearch.Release();
                        readCnt.WaitOne();
                        read--;
                        if (read == 0)
                        {
                            lockAddExcange.Release();
                        }
                        readCnt.Release();
                        return true;
                    }
                }
                catch (Exception e) { }
            }
        }
        if (_searchLimit)
            slimSearch.Release();
        readCnt.WaitOne();
        read--;
        if (read == 0)
        {
            lockAddExcange.Release();
        }
        readCnt.Release();
        return false;
    }

    public bool searchInCol(int col, String str, ref int row)
    {
        // perform search in specific col
        readCnt.WaitOne();
        read++;
        if (read == 1)
            lockAddExcange.WaitOne();
        readCnt.Release();
        if (_searchLimit)
            slimSearch.Wait();
        if (boundary(0, col - 1))
        {
            for (int i = 0; i < _row; i++)
            {
                try
                {
                    if (sheet[i, col - 1].getStr().Equals(str))
                    {
                        row = i + 1;
                        if (_searchLimit)
                            slimSearch.Release();
                        readCnt.WaitOne();
                        read--;
                        if (read == 0)
                        {
                            lockAddExcange.Release();
                        }
                        readCnt.Release();
                        return true;
                    }
                }
                catch (Exception e) { }
            }
        }
        if (_searchLimit)
            slimSearch.Release();
        readCnt.WaitOne();
        read--;
        if (read == 0)
        {
            lockAddExcange.Release();
        }
        readCnt.Release();
        return false;
    }

    public bool searchInRange(int col1, int col2, int row1, int row2, String str, ref int row, ref int col)
    {
        // perform search within spesific range: [row1:row2,col1:col2] 
        // includes col1 ,col2, row1, row2
        col1--; col2--; row1--; row2--;
        readCnt.WaitOne();
        read++;
        if (read == 1)
            lockAddExcange.WaitOne();
        readCnt.Release();
        if (_searchLimit)
            slimSearch.Wait();
        try
        {
            if (boundary(row1, col1) && boundary(row2, col2))
            {
                for (int i = row1; i <= row2; i++)
                {
                    for (int j = col1; j <= col2; j++)
                    {
                        if (str.Equals(sheet[i, j].getStr()))
                        {
                            row = i + 1;
                            col = j + 1;
                            if (_searchLimit)
                                slimSearch.Release();
                            readCnt.WaitOne();
                            read--;
                            if (read == 0)
                            {
                                lockAddExcange.Release();
                            }
                            readCnt.Release();
                            return true;
                        }
                    }
                }
            }
        }
        catch (Exception e) { }
        if (_searchLimit)
            slimSearch.Release();
        readCnt.WaitOne();
        read--;
        if (read == 0)
        {
            lockAddExcange.Release();
        }
        readCnt.Release();
        return false;
    }

    public bool searchString(String str, ref int row, ref int col)
    {
        // search the cell with string str, and return true/false accordingly.
        // stores the location in row,col.
        // return the first cell that contains the string (search from first row to the last row)

        readCnt.WaitOne();
        read++;
        if (read == 1)
            lockAddExcange.WaitOne();
        readCnt.Release();
        if (_searchLimit)
            slimSearch.Wait();
        try
        {
            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _col; j++)
                {
                    if (str.Equals(sheet[i, j].getStr()))
                    {
                        row = i + 1;
                        col = j + 1;
                        if (_searchLimit)
                            slimSearch.Release();
                        readCnt.WaitOne();
                        read--;
                        if (read == 0)
                        {
                            lockAddExcange.Release();
                        }
                        readCnt.Release();
                        return true;
                    }
                }
            }
        }
        catch (Exception e) { }
        if (_searchLimit)
            slimSearch.Release();
        readCnt.WaitOne();
        read--;
        if (read == 0)
        {
            lockAddExcange.Release();
        }
        readCnt.Release();
        return false;
    }

    public bool setConcurrentSearchLimit(int nUsers)
    {
        // this function aims to limit the number of users that can perform the *search operations* concurrently.
        // The default is no limit. When the function is called, the max number of concurrent search operations is set to nUsers. 
        // In this case, additional search operations will wait for existing search to finish.
        concurrent.WaitOne();
        if (_searchLimit == true)
        {
            if (nUsers > semaphoreCount)
            {
                slimSearch.Release(nUsers - semaphoreCount);
                concurrent.ReleaseMutex();
                return true;
            }
            concurrent.ReleaseMutex();
            return false;
        }
        // the fisrt time to limit the search number.
        else if (nUsers < semaphoreCount)
        {
            _searchLimit = true;
            semaphoreCount = nUsers;
            slimSearch.Release(nUsers);
            concurrent.ReleaseMutex();
            return true;
        }
        concurrent.ReleaseMutex();
        return false;
    }

    public bool save(String fileName)
    {
        // save the spreadsheet to a file fileName.
        // you can decide the format you save the data. There are several options.
        string name = fileName;
        saveM.WaitOne();
        if (Thread.CurrentThread.Name != null)
            name += cnt + ".dat";
        cnt++;
        saveM.ReleaseMutex();
        using (StreamWriter outfile = new StreamWriter(name))
            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _col; j++)
                {
                    outfile.Write("{0},", sheet[i, j].getStr());
                }
                outfile.WriteLine();
            }
        return true;
    }

    public bool load(String fileName)
    {
        // load the spreadsheet from fileName
        // replace the data and size of the current spreadsheet with the loaded dataed

        StreamReader objInput = new StreamReader(fileName, System.Text.Encoding.Default);
        string contents = objInput.ReadToEnd().Trim();
        string[] split = System.Text.RegularExpressions.Regex.Split(contents, "\\s+");
        int srow, scol;
        string[] currentRow = split[0].Split(',');
        srow = split.Length;
        scol = currentRow.Length - 1;
        Cell[,] nLoad = new Cell[srow, scol];
        int i = 0, j = 0;
        using (TextFieldParser parser = new TextFieldParser(fileName))
        {
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");
            while (!parser.EndOfData)
            {
                //Processing row
                string[] fields = parser.ReadFields();
                int len = fields.Length - 1;
                for (int i1 = 0; i1 < len; i1++)
                {
                    string field = fields[i1];
                    nLoad[i, j] = new Cell("");
                    nLoad[i, j].setStr(field);
                    j++;
                }
                i++;
                j = 0;
            }
        }
        this.sheet = nLoad;
        _row = srow;
        _col = scol;
        return true;
    }

    private bool boundary(int Trow, int Tcol)
    {
        //function that check if the parameters Trow and Tcol are possible in our boundarys
        if (Trow < _row && Tcol < _col)
            return true;
        return false;
    }
}




