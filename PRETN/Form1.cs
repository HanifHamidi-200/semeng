using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRETN
{
    public partial class Form1 : Form
    {
        private String msShuffle;
        private String msShuffle2;
        private String msShuffle3;
        private int mnCol = 0, mnRow = 0;
        private int mnSide, mnIndex;

        private void fNav(int nMode)
        {
            if (nMode == 1)
            {
                switch (mnSide)
                {
                    case 1:
                        if (mnIndex == 8)
                        {
                            mnCol = 2;
                            mnRow = 8;
                            mnSide = 2;
                            mnIndex = 2;
                        }
                        else
                        {
                            mnCol = 1;
                            mnRow++;
                            mnSide = 1;
                            mnIndex = mnRow;
                        }
                        break;
                    case 2:
                        if (mnIndex == 8)
                        {
                            mnCol = 8;
                            mnRow = 7;
                            mnSide = 3;
                            mnIndex = 7;
                        }
                        else
                        {
                            mnCol++;
                            mnRow=8;
                            mnSide = 2;
                            mnIndex = mnCol;
                        }
                        break;

                    case 3:
                        if (mnIndex == 1)
                        {
                            mnCol = 7;
                            mnRow = 1;
                            mnSide = 4;
                            mnIndex = 7;
                        }
                        else
                        {
                            mnCol = 8;
                            mnRow--;
                            mnSide = 3;
                            mnIndex = mnRow;
                        }
                        break;

                    default:
                        if (mnIndex == 1)
                        {
                            mnCol = 1;
                            mnRow = 2;
                            mnSide = 1;
                            mnIndex = 2;
                        }
                        else
                        {
                            mnCol--;
                            mnRow=1;
                            mnSide = 4;
                            mnIndex = mnCol;
                        }
                        break;


                }
            }
            else
            {
                switch (mnSide)
                {
                    case 1:
                        if (mnIndex == 1)
                        {
                            mnCol = 2;
                            mnRow = 1;
                            mnSide = 4;
                            mnIndex = 2;
                        }
                        else
                        {
                            mnCol = 1;
                            mnRow--;
                            mnSide = 1;
                            mnIndex = mnRow;
                        }
                        break;
                    case 2:
                        if (mnIndex == 1)
                        {
                            mnCol = 1;
                            mnRow = 7;
                            mnSide = 1;
                            mnIndex = 7;
                        }
                        else
                        {
                            mnCol--;
                            mnRow = 8;
                            mnSide = 2;
                            mnIndex = mnCol;
                        }
                        break;

                    case 3:
                        if (mnIndex == 8)
                        {
                            mnCol = 7;
                            mnRow = 8;
                            mnSide = 2;
                            mnIndex = 7;
                        }
                        else
                        {
                            mnCol = 8;
                            mnRow++;
                            mnSide = 3;
                            mnIndex = mnRow;
                        }
                        break;

                    default:
                        if (mnIndex == 8)
                        {
                            mnCol = 8;
                            mnRow = 2;
                            mnSide = 3;
                            mnIndex = 2;
                        }
                        else
                        {
                            mnCol++;
                            mnRow = 1;
                            mnSide = 4;
                            mnIndex = mnCol;
                        }
                        break;


                }

            }
            fUpdateDisplay();
        }
        private void fKnobCoordinantes()
        {
            switch (mnSide)
            {
                case 1:
                    mnCol = 1;
                    mnRow = mnIndex;
                    break;
                case 2:
                    mnCol = mnIndex;
                    mnRow = 8;
                    break;
                case 3:
                    mnCol = 8;
                    mnRow = mnIndex;
                    break;
                default:
                    mnCol = mnIndex;
                    mnRow = 1;
                    break;
            }
        }
        private void fNewCoordinates(ref int nCol,ref int nRow)
        {
            Random rnd1 = new Random();
            int nDirection = rnd1.Next(1, 5);
            bool bFound = false;
            int nTries = 0;
            int nPos, nType;

            switch (nDirection)
            {
                case 1:
                    do
                    {
                        nTries++;
                        nRow--;
                        if (nRow == 0)
                        {
                            nRow = 8;
                        }
                        if (nTries > 5)
                        {
                            bFound = true;
                        }
                        else
                        {
                            nPos = (nCol - 1) * 8 + nRow;
                            nType = fHoletype(msShuffle3, nPos);
                            if (nType == 1)
                            {
                                bFound = true;
                            }
                        }
                    } while (bFound == false);
                    break;
                case 2:
                    do
                    {
                        nTries++;
                        nCol++;
                        if (nCol == 9)
                        {
                            nCol = 1;
                        }
                        if (nTries > 5)
                        {
                            bFound = true;
                        }
                        else
                        {
                            nPos = (nCol - 1) * 8 + nRow;
                            nType = fHoletype(msShuffle3, nPos);
                            if (nType == 1)
                            {
                                bFound = true;
                            }
                        }
                    } while (bFound == false);
                    break;
                case 3:
                    do
                    {
                        nTries++;
                        nRow++;
                        if (nRow == 9)
                        {
                            nRow = 1;
                        }
                        if (nTries > 5)
                        {
                            bFound = true;
                        }
                        else
                        {
                            nPos = (nCol - 1) * 8 + nRow;
                            nType = fHoletype(msShuffle3, nPos);
                            if (nType == 1)
                            {
                                bFound = true;
                            }
                        }
                    } while (bFound == false);
                    break;
                default:
                    do
                    {
                        nTries++;
                        nCol--;
                        if (nCol == 0)
                        {
                            nCol = 8;
                        }
                        if (nTries > 5)
                        {
                            bFound = true;
                        }
                        else
                        {
                            nPos = (nCol - 1) * 8 + nRow;
                            nType = fHoletype(msShuffle3, nPos);
                            if (nType == 1)
                            {
                                bFound = true;
                            }
                        }
                    } while (bFound == false);
                    break;
            }
        }
        private void fSpill(int nCol,int nRow)
        {
            Random rnd1 = new Random();
            int nLength = rnd1.Next(4, 11);
            int nPos;

            for (int i = 1; i <= nLength; i++)
            {
                fNewCoordinates(ref nCol, ref nRow);
                nPos = (nCol - 1) * 8 + nRow;
                fPlace2("03", nPos);
            }
        }

        private void fReset()
        {
            Random rnd1 = new Random();
            String sTwo = null;
            int nCount = rnd1.Next(4, 9);
            int nPos,nType;
            int nCol = 0, nRow = 0;
       
            msShuffle = "01020304050607080910111213141516171819202122232425262728293021323334353637383940414243444546474849505152535455565758596061626364";
            msShuffle2 = null;
            msShuffle3 = null;

            for (int i = 1; i <= 64; i++)
            {
                sTwo = "01";
                msShuffle2 = msShuffle2 + sTwo;
                msShuffle3 = msShuffle3 + sTwo;
            }

            for (int i = 1; i <= nCount; i++)
            {
                fFree(ref nCol, ref nRow);
                nPos = (nCol - 1) * 8 + nRow;
                fPlace("02", nPos);
            }

            for(int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    nPos = (i - 1) * 8 + j;
                    nType = fHoletype(msShuffle2, nPos);
                    sTwo = "0" + Convert.ToString(nType);
                    fPlace2(sTwo, nPos);
                }
            }
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    nPos = (i - 1) * 8 + j;
                    nType = fHoletype(msShuffle3, nPos);
                    if (nType == 2)
                    {
                        fSpill(i, j);
                    }
                }
            }

            mnSide = rnd1.Next(1, 5);
            mnIndex = rnd1.Next(1, 9);

            fUpdateDisplay();

        }

        private void fUpdateDisplay()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate = 1;

            //1
            nType = fHoletype(msShuffle2, 1);
            fPeek(nType, nRotate, ref _pic);
            pic11.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 2);
            fPeek(nType, nRotate, ref _pic);
            pic12.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 3);
            fPeek(nType, nRotate, ref _pic);
            pic13.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 4);
            fPeek(nType, nRotate, ref _pic);
            pic14.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 5);
            fPeek(nType, nRotate, ref _pic);
            pic15.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 6);
            fPeek(nType, nRotate, ref _pic);
            pic16.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 7);
            fPeek(nType, nRotate, ref _pic);
            pic17.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 8);
            fPeek(nType, nRotate, ref _pic);
            pic18.Image = _pic.Image;

            //2
            nType = fHoletype(msShuffle2, 9);
            fPeek(nType, nRotate, ref _pic);
            pic21.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 10);
            fPeek(nType, nRotate, ref _pic);
            pic22.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 11);
            fPeek(nType, nRotate, ref _pic);
            pic23.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 12);
            fPeek(nType, nRotate, ref _pic);
            pic24.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 13);
            fPeek(nType, nRotate, ref _pic);
            pic25.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 14);
            fPeek(nType, nRotate, ref _pic);
            pic26.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 15);
            fPeek(nType, nRotate, ref _pic);
            pic27.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 16);
            fPeek(nType, nRotate, ref _pic);
            pic28.Image = _pic.Image;

            //3
            nType = fHoletype(msShuffle2, 17);
            fPeek(nType, nRotate, ref _pic);
            pic31.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 18);
            fPeek(nType, nRotate, ref _pic);
            pic32.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 19);
            fPeek(nType, nRotate, ref _pic);
            pic33.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 20);
            fPeek(nType, nRotate, ref _pic);
            pic34.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 21);
            fPeek(nType, nRotate, ref _pic);
            pic35.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 22);
            fPeek(nType, nRotate, ref _pic);
            pic36.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 23);
            fPeek(nType, nRotate, ref _pic);
            pic37.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 24);
            fPeek(nType, nRotate, ref _pic);
            pic38.Image = _pic.Image;

            //4
            nType = fHoletype(msShuffle2, 25);
            fPeek(nType, nRotate, ref _pic);
            pic41.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 26);
            fPeek(nType, nRotate, ref _pic);
            pic42.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 27);
            fPeek(nType, nRotate, ref _pic);
            pic43.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 28);
            fPeek(nType, nRotate, ref _pic);
            pic44.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 29);
            fPeek(nType, nRotate, ref _pic);
            pic45.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 30);
            fPeek(nType, nRotate, ref _pic);
            pic46.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 31);
            fPeek(nType, nRotate, ref _pic);
            pic47.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 32);
            fPeek(nType, nRotate, ref _pic);
            pic48.Image = _pic.Image;

            //5
            nType = fHoletype(msShuffle2, 33);
            fPeek(nType, nRotate, ref _pic);
            pic51.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 34);
            fPeek(nType, nRotate, ref _pic);
            pic52.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 35);
            fPeek(nType, nRotate, ref _pic);
            pic53.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 36);
            fPeek(nType, nRotate, ref _pic);
            pic54.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 37);
            fPeek(nType, nRotate, ref _pic);
            pic55.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 38);
            fPeek(nType, nRotate, ref _pic);
            pic56.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 39);
            fPeek(nType, nRotate, ref _pic);
            pic57.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 40);
            fPeek(nType, nRotate, ref _pic);
            pic58.Image = _pic.Image;

            //6
            nType = fHoletype(msShuffle2, 41);
            fPeek(nType, nRotate, ref _pic);
            pic61.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 42);
            fPeek(nType, nRotate, ref _pic);
            pic62.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 43);
            fPeek(nType, nRotate, ref _pic);
            pic63.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 44);
            fPeek(nType, nRotate, ref _pic);
            pic64.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 45);
            fPeek(nType, nRotate, ref _pic);
            pic65.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 46);
            fPeek(nType, nRotate, ref _pic);
            pic66.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 47);
            fPeek(nType, nRotate, ref _pic);
            pic67.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 48);
            fPeek(nType, nRotate, ref _pic);
            pic68.Image = _pic.Image;

            //7
            nType = fHoletype(msShuffle2, 49);
            fPeek(nType, nRotate, ref _pic);
            pic71.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 50);
            fPeek(nType, nRotate, ref _pic);
            pic72.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 51);
            fPeek(nType, nRotate, ref _pic);
            pic73.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 52);
            fPeek(nType, nRotate, ref _pic);
            pic74.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 53);
            fPeek(nType, nRotate, ref _pic);
            pic75.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 54);
            fPeek(nType, nRotate, ref _pic);
            pic76.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 55);
            fPeek(nType, nRotate, ref _pic);
            pic77.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 56);
            fPeek(nType, nRotate, ref _pic);
            pic78.Image = _pic.Image;

            //8
            nType = fHoletype(msShuffle2, 57);
            fPeek(nType, nRotate, ref _pic);
            pic81.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 58);
            fPeek(nType, nRotate, ref _pic);
            pic82.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 59);
            fPeek(nType, nRotate, ref _pic);
            pic83.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 60);
            fPeek(nType, nRotate, ref _pic);
            pic84.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 61);
            fPeek(nType, nRotate, ref _pic);
            pic85.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 62);
            fPeek(nType, nRotate, ref _pic);
            pic86.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 63);
            fPeek(nType, nRotate, ref _pic);
            pic87.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 64);
            fPeek(nType, nRotate, ref _pic);
            pic88.Image = _pic.Image;

            fKnobCoordinantes();
            fIcon();
        }

        private void fIcon()
        {
            PictureBox _pic = new PictureBox();
            int nType = 4;
            int nRotate = 1;

            switch (mnCol)
            {
                case 1:
                    switch (mnRow)
                    {
                        case 1:
                            fPeek(nType, nRotate, ref _pic);
                            pic11.Image = _pic.Image;
                            break;
                        case 2:
                            fPeek(nType, nRotate, ref _pic);
                            pic12.Image = _pic.Image;
                            break;
                        case 3:
                            fPeek(nType, nRotate, ref _pic);
                            pic13.Image = _pic.Image;
                            break;
                        case 4:
                            fPeek(nType, nRotate, ref _pic);
                            pic14.Image = _pic.Image;
                            break;
                        case 5:
                            fPeek(nType, nRotate, ref _pic);
                            pic15.Image = _pic.Image;
                            break;
                        case 6:
                            fPeek(nType, nRotate, ref _pic);
                            pic16.Image = _pic.Image;
                            break;
                        case 7:
                            fPeek(nType, nRotate, ref _pic);
                            pic17.Image = _pic.Image;
                            break;
                        default:
                            fPeek(nType, nRotate, ref _pic);
                            pic18.Image = _pic.Image;
                            break;
                    }
                    break;
                case 2:
                    switch (mnRow)
                    {
                        case 1:
                            fPeek(nType, nRotate, ref _pic);
                            pic21.Image = _pic.Image;
                            break;
                        case 2:
                            fPeek(nType, nRotate, ref _pic);
                            pic22.Image = _pic.Image;
                            break;
                        case 3:
                            fPeek(nType, nRotate, ref _pic);
                            pic23.Image = _pic.Image;
                            break;
                        case 4:
                            fPeek(nType, nRotate, ref _pic);
                            pic24.Image = _pic.Image;
                            break;
                        case 5:
                            fPeek(nType, nRotate, ref _pic);
                            pic25.Image = _pic.Image;
                            break;
                        case 6:
                            fPeek(nType, nRotate, ref _pic);
                            pic26.Image = _pic.Image;
                            break;
                        case 7:
                            fPeek(nType, nRotate, ref _pic);
                            pic27.Image = _pic.Image;
                            break;
                        default:
                            fPeek(nType, nRotate, ref _pic);
                            pic28.Image = _pic.Image;
                            break;
                    }
                    break;
                case 3:
                    switch (mnRow)
                    {
                        case 1:
                            fPeek(nType, nRotate, ref _pic);
                            pic31.Image = _pic.Image;
                            break;
                        case 2:
                            fPeek(nType, nRotate, ref _pic);
                            pic32.Image = _pic.Image;
                            break;
                        case 3:
                            fPeek(nType, nRotate, ref _pic);
                            pic33.Image = _pic.Image;
                            break;
                        case 4:
                            fPeek(nType, nRotate, ref _pic);
                            pic34.Image = _pic.Image;
                            break;
                        case 5:
                            fPeek(nType, nRotate, ref _pic);
                            pic35.Image = _pic.Image;
                            break;
                        case 6:
                            fPeek(nType, nRotate, ref _pic);
                            pic36.Image = _pic.Image;
                            break;
                        case 7:
                            fPeek(nType, nRotate, ref _pic);
                            pic37.Image = _pic.Image;
                            break;
                        default:
                            fPeek(nType, nRotate, ref _pic);
                            pic38.Image = _pic.Image;
                            break;
                    }
                    break;
                case 4:
                    switch (mnRow)
                    {
                        case 1:
                            fPeek(nType, nRotate, ref _pic);
                            pic41.Image = _pic.Image;
                            break;
                        case 2:
                            fPeek(nType, nRotate, ref _pic);
                            pic42.Image = _pic.Image;
                            break;
                        case 3:
                            fPeek(nType, nRotate, ref _pic);
                            pic43.Image = _pic.Image;
                            break;
                        case 4:
                            fPeek(nType, nRotate, ref _pic);
                            pic44.Image = _pic.Image;
                            break;
                        case 5:
                            fPeek(nType, nRotate, ref _pic);
                            pic45.Image = _pic.Image;
                            break;
                        case 6:
                            fPeek(nType, nRotate, ref _pic);
                            pic46.Image = _pic.Image;
                            break;
                        case 7:
                            fPeek(nType, nRotate, ref _pic);
                            pic47.Image = _pic.Image;
                            break;
                        default:
                            fPeek(nType, nRotate, ref _pic);
                            pic48.Image = _pic.Image;
                            break;
                    }
                    break;
                case 5:
                    switch (mnRow)
                    {
                        case 1:
                            fPeek(nType, nRotate, ref _pic);
                            pic51.Image = _pic.Image;
                            break;
                        case 2:
                            fPeek(nType, nRotate, ref _pic);
                            pic52.Image = _pic.Image;
                            break;
                        case 3:
                            fPeek(nType, nRotate, ref _pic);
                            pic53.Image = _pic.Image;
                            break;
                        case 4:
                            fPeek(nType, nRotate, ref _pic);
                            pic54.Image = _pic.Image;
                            break;
                        case 5:
                            fPeek(nType, nRotate, ref _pic);
                            pic55.Image = _pic.Image;
                            break;
                        case 6:
                            fPeek(nType, nRotate, ref _pic);
                            pic56.Image = _pic.Image;
                            break;
                        case 7:
                            fPeek(nType, nRotate, ref _pic);
                            pic57.Image = _pic.Image;
                            break;
                        default:
                            fPeek(nType, nRotate, ref _pic);
                            pic58.Image = _pic.Image;
                            break;
                    }
                    break;
                case 6:
                    switch (mnRow)
                    {
                        case 1:
                            fPeek(nType, nRotate, ref _pic);
                            pic61.Image = _pic.Image;
                            break;
                        case 2:
                            fPeek(nType, nRotate, ref _pic);
                            pic62.Image = _pic.Image;
                            break;
                        case 3:
                            fPeek(nType, nRotate, ref _pic);
                            pic63.Image = _pic.Image;
                            break;
                        case 4:
                            fPeek(nType, nRotate, ref _pic);
                            pic64.Image = _pic.Image;
                            break;
                        case 5:
                            fPeek(nType, nRotate, ref _pic);
                            pic65.Image = _pic.Image;
                            break;
                        case 6:
                            fPeek(nType, nRotate, ref _pic);
                            pic66.Image = _pic.Image;
                            break;
                        case 7:
                            fPeek(nType, nRotate, ref _pic);
                            pic67.Image = _pic.Image;
                            break;
                        default:
                            fPeek(nType, nRotate, ref _pic);
                            pic68.Image = _pic.Image;
                            break;
                    }
                    break;
                case 7:
                    switch (mnRow)
                    {
                        case 1:
                            fPeek(nType, nRotate, ref _pic);
                            pic71.Image = _pic.Image;
                            break;
                        case 2:
                            fPeek(nType, nRotate, ref _pic);
                            pic72.Image = _pic.Image;
                            break;
                        case 3:
                            fPeek(nType, nRotate, ref _pic);
                            pic73.Image = _pic.Image;
                            break;
                        case 4:
                            fPeek(nType, nRotate, ref _pic);
                            pic74.Image = _pic.Image;
                            break;
                        case 5:
                            fPeek(nType, nRotate, ref _pic);
                            pic75.Image = _pic.Image;
                            break;
                        case 6:
                            fPeek(nType, nRotate, ref _pic);
                            pic76.Image = _pic.Image;
                            break;
                        case 7:
                            fPeek(nType, nRotate, ref _pic);
                            pic77.Image = _pic.Image;
                            break;
                        default:
                            fPeek(nType, nRotate, ref _pic);
                            pic78.Image = _pic.Image;
                            break;
                    }
                    break;
                default:
                    switch (mnRow)
                    {
                        case 1:
                            fPeek(nType, nRotate, ref _pic);
                            pic81.Image = _pic.Image;
                            break;
                        case 2:
                            fPeek(nType, nRotate, ref _pic);
                            pic82.Image = _pic.Image;
                            break;
                        case 3:
                            fPeek(nType, nRotate, ref _pic);
                            pic83.Image = _pic.Image;
                            break;
                        case 4:
                            fPeek(nType, nRotate, ref _pic);
                            pic84.Image = _pic.Image;
                            break;
                        case 5:
                            fPeek(nType, nRotate, ref _pic);
                            pic85.Image = _pic.Image;
                            break;
                        case 6:
                            fPeek(nType, nRotate, ref _pic);
                            pic86.Image = _pic.Image;
                            break;
                        case 7:
                            fPeek(nType, nRotate, ref _pic);
                            pic87.Image = _pic.Image;
                            break;
                        default:
                            fPeek(nType, nRotate, ref _pic);
                            pic88.Image = _pic.Image;
                            break;
                    }
                    break;
            }
        }


        private void fFree(ref int nCol, ref int nRow)
        {
            Random rnd1 = new Random();
            bool bFound = false;
            int nType = 0, nPos = 0;

            do
            {
                nCol = rnd1.Next(1, 9);
                nRow = rnd1.Next(1, 9);
                nPos = (nCol - 1) * 8 + nRow;
                nType = fHoletype(msShuffle2, nPos);
                if (nType == 1)
                {
                    bFound = true;
                }
            } while (bFound != true);

        }
        private void fPlace(String sText, int nPos)
        {
            msShuffle2 = msShuffle2.Substring(0, nPos * 2 - 2) + sText + msShuffle2.Substring(nPos * 2, (64 - nPos) * 2);
        }
        private void fPlace2(String sText, int nPos)
        {
            msShuffle3 = msShuffle3.Substring(0, nPos * 2 - 2) + sText + msShuffle3.Substring(nPos * 2, (64 - nPos) * 2);
        }
        private int fHoletype(String sShuffle, int nSquare)
        {
            int nType = 0;

            nType = Convert.ToInt32(sShuffle.Substring(nSquare * 2 - 2, 2));
            return nType;
        }

        private void BtnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F empty.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F blood.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F bloodspill.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F KnobsDescription.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            switch (nValue)
            {
                case 1:
                    _pic2 = picture1;
                    break;
                case 2:
                    _pic2 = picture2;
                    break;
                case 3:
                    _pic2 = picture3;
                    break;
                case 4:
                    _pic2 = picture4;
                    break;
                default:
                    _pic2 = picture5;
                    break;
            }
            for (int i = 1; i <= nRotate - 1; i++)
            {
                _pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

        }

        private void BtnNavClockwise_Click(object sender, EventArgs e)
        {
            fNav(1);
        }

        private void BtnNavAnticlockwise_Click(object sender, EventArgs e)
        {
            fNav(2);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
