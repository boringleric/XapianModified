# XapianModified
Xapian 1.2.23 修改版，毕业设计使用，包括C#binding  
1、使用VS编译，依据xapian-core\win32\README.txt编译；    
2、修改的内容是为了避免VS编译出错修改的，此外还修改了编码格式，为了避免中文utf-8编码错误；  
3、附带的dlib和pcre在lib库中。

曾经使用的C#编译指令为：
./configure --with-csharp CSC="C:/PROGRA\~2/MSBuild/14.0/Bin/amd64/csc.exe" SN="C:/PROGRA\~2/Microsoft\ SDKs/Windows/v8.1A/bin/NETFX\ 4.5.1\ Tools/x64/sn.exe" GACUTIL="C:/PROGRA\~2/Microsoft\ SDKs/Windows/v8.1A/bin/NETFX\ 4.5.1\ Tools/x64/gacutil.exe" XAPIAN_CONFIG="D:/xaplinux/xapian-core-1.4.2/xapian-config"
