# SharpRandomFile
C# Random File generator
This program will generate a file containing random data.

Running the SharpRandomFile.exe will require 2 arguments, FilePath and FileSize.
FileSize will use 1024 blocksizes to prevent rounding errors.

Example execution to create a tempfile.zip of 100Mb;
"execute-assembly SharpRandomFile.exe C:\Temp\tempfile.zip 100"
