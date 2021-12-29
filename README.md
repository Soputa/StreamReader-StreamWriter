# StreamReader-StreamWriter
Windows Forms App .Net. The program will read a file and then write vaules from that file to a new file.

This windows form will read in the file from the specified location in the string variable rainNew. It will then process data from the file. The processing for lines that meet the criteria for a line on the new file are in the method “GoodLine”(found on line 143). If the value read meets the criteria and is the not the sentinel value (0.474452) it will be written to the new file. Once the last line of the reader is read or the sentinel value is read it will close the FileStearm and the Stream Reader. 
