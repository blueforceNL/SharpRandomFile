# SharpRandomFile
This program will generate a file containing random data.

# Installation

- Download from Github
- Compile
- Run

Running SharpRandomFile.exe will require 2 arguments, FilePath and FileSize.
FileSize will use 1024 blocksizes to prevent rounding errors.

Example execution to create a tempfile.zip of 100Mb:

  execute-assembly SharpRandomFile.exe C:\Temp\tempfile.zip 100

# What's it for?
So, you're almost done with your Red Team campaign. The last step is to exfiltrate data. Maybe you need to prove that you can, or maybe you want to give the Blue Team a final chance to shine. You can exfil the actual interesting secret data you found, but this might result in you leaving the organisation along with the data. Better to drop this executable on your target and use it to generate some files with random data.
