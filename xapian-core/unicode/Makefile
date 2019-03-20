# Makefile for Microsoft Visual C++ 7.0 (or compatible)
# Originally by Mark Hammond

# Will build a Win32 static library (non-debug) libunicode.lib



!INCLUDE ..\win32\config.mak


OUTDIR=..\win32\$(XAPIAN_DEBUG_OR_RELEASE)\libs
INTDIR=.\

ALL : "$(OUTDIR)\libunicode.lib" 

OBJS= \
            $(INTDIR)\utf8itor.obj \
            $(INTDIR)\unicode-data.obj

SRCS= \
            $(INTDIR)\utf8itor.cc \
            $(INTDIR)\unicode-data.cc

	    
CLEAN :
	-@erase "$(OUTDIR)\libunicode.lib"
	-@erase "*.pch"
	-@erase "$(INTDIR)\*.pdb"
        -@erase $(OBJS)


"$(OUTDIR)" :
    if not exist "$(OUTDIR)/$(NULL)" mkdir "$(OUTDIR)"

CPP_PROJ=$(CPPFLAGS_EXTRA) \
 -I"..\api" -I"..\languages" \
 -Fo"$(INTDIR)\\" -Tp$(INPUTNAME)

CPP_OBJS=..\win32\$(XAPIAN_DEBUG_OR_RELEASE)
CPP_SBRS=.

"$(OUTDIR)\libunicode.lib" : "$(OUTDIR)" $(DEF_FILE) $(OBJS)
    $(LIB32) @<<
  $(LIB32_FLAGS) /out:"$(OUTDIR)\libunicode.lib" $(DEF_FLAGS) $(OBJS)
<<

# inference rules, showing how to create one type of file from another with the same root name
{.}.cc{$(INTDIR)}.obj::
	$(CPP) @<<
	$(CPP_PROJ) $< 
<<

{.}.cc{$(CPP_SBRS)}.sbr::
   $(CPP) @<<
   $(CPP_PROJ) $< 
<<

# Calculate any header dependencies and automatically insert them into this file
HEADERS :
    -@erase deps.d
    $(CPP) -showIncludes $(CPP_PROJ) $(SRCS) >>deps.d
    if exist "..\win32\$(DEPEND)" ..\win32\$(DEPEND) 
# DO NOT DELETE THIS LINE -- xapdep depends on it.


#Automatically generated dependencies from XAPDEP follow:

utf8itor.obj : "E:\xapian-1.2.23\xapian-core\config.h" 
utf8itor.obj : "E:\xapian-1.2.23\xapian-core\include\xapian/unicode.h" 
utf8itor.obj : "E:\xapian-1.2.23\xapian-core\include\xapian/visibility.h" 
utf8itor.obj : "E:\xapian-1.2.23\xapian-core\include\xapian/version.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\string" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\istream" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\ostream" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\ios" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\xlocnum" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\climits" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\yvals.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\xkeycheck.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\crtdefs.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\vcruntime.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\sal.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\ConcurrencySal.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\vadefs.h" 
utf8itor.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\corecrt.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\vcruntime.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\use_ansi.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\limits.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\vcruntime.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\cmath" 
utf8itor.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\math.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\xtgmath.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\xtr1common" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\cstdlib" 
utf8itor.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\stdlib.h" 
utf8itor.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\corecrt_malloc.h" 
utf8itor.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\corecrt_search.h" 
utf8itor.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\stddef.h" 
utf8itor.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\corecrt_wstdlib.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\cstdio" 
utf8itor.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\stdio.h" 
utf8itor.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\corecrt_wstdio.h" 
utf8itor.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\corecrt_stdio_config.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\streambuf" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\xiosbase" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\xlocale" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\cstring" 
utf8itor.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\string.h" 
utf8itor.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\corecrt_memory.h" 
utf8itor.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\corecrt_memcpy_s.h" 
utf8itor.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\errno.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\vcruntime_string.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\vcruntime.h" 
utf8itor.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\corecrt_wstring.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\stdexcept" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\exception" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\type_traits" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\xstddef" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\cstddef" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\initializer_list" 
utf8itor.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\malloc.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\vcruntime_exception.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\eh.h" 
utf8itor.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\corecrt_terminate.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\xstring" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\xmemory0" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\cstdint" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\stdint.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\vcruntime.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\limits" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\ymath.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\cfloat" 
utf8itor.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\float.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\cwchar" 
utf8itor.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\wchar.h" 
utf8itor.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\corecrt_wconio.h" 
utf8itor.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\corecrt_wctype.h" 
utf8itor.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\corecrt_wdirect.h" 
utf8itor.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\corecrt_wio.h" 
utf8itor.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\corecrt_share.h" 
utf8itor.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\corecrt_wprocess.h" 
utf8itor.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\corecrt_wtime.h" 
utf8itor.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\sys/stat.h" 
utf8itor.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\sys/types.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\new" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\vcruntime_new.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\vcruntime.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\xutility" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\utility" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\iosfwd" 
utf8itor.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\crtdbg.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\vcruntime_new_debug.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\xatomic0.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\intrin.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\vcruntime.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\setjmp.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\vcruntime.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\immintrin.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\wmmintrin.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\nmmintrin.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\smmintrin.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\tmmintrin.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\pmmintrin.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\emmintrin.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\xmmintrin.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\mmintrin.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\ammintrin.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\typeinfo" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\vcruntime_typeinfo.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\vcruntime.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\xlocinfo" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\xlocinfo.h" 
utf8itor.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\ctype.h" 
utf8itor.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\locale.h" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\xfacet" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\system_error" 
utf8itor.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\cerrno" 
utf8itor.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\share.h" 
unicode-data.obj : "E:\xapian-1.2.23\xapian-core\config.h" 
unicode-data.obj : "E:\xapian-1.2.23\xapian-core\include\xapian/unicode.h" 
unicode-data.obj : "E:\xapian-1.2.23\xapian-core\include\xapian/visibility.h" 
unicode-data.obj : "E:\xapian-1.2.23\xapian-core\include\xapian/version.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\string" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\istream" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\ostream" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\ios" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\xlocnum" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\climits" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\yvals.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\xkeycheck.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\crtdefs.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\vcruntime.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\sal.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\ConcurrencySal.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\vadefs.h" 
unicode-data.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\corecrt.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\vcruntime.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\use_ansi.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\limits.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\vcruntime.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\cmath" 
unicode-data.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\math.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\xtgmath.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\xtr1common" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\cstdlib" 
unicode-data.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\stdlib.h" 
unicode-data.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\corecrt_malloc.h" 
unicode-data.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\corecrt_search.h" 
unicode-data.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\stddef.h" 
unicode-data.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\corecrt_wstdlib.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\cstdio" 
unicode-data.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\stdio.h" 
unicode-data.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\corecrt_wstdio.h" 
unicode-data.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\corecrt_stdio_config.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\streambuf" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\xiosbase" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\xlocale" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\cstring" 
unicode-data.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\string.h" 
unicode-data.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\corecrt_memory.h" 
unicode-data.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\corecrt_memcpy_s.h" 
unicode-data.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\errno.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\vcruntime_string.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\vcruntime.h" 
unicode-data.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\corecrt_wstring.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\stdexcept" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\exception" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\type_traits" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\xstddef" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\cstddef" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\initializer_list" 
unicode-data.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\malloc.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\vcruntime_exception.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\eh.h" 
unicode-data.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\corecrt_terminate.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\xstring" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\xmemory0" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\cstdint" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\stdint.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\vcruntime.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\limits" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\ymath.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\cfloat" 
unicode-data.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\float.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\cwchar" 
unicode-data.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\wchar.h" 
unicode-data.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\corecrt_wconio.h" 
unicode-data.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\corecrt_wctype.h" 
unicode-data.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\corecrt_wdirect.h" 
unicode-data.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\corecrt_wio.h" 
unicode-data.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\corecrt_share.h" 
unicode-data.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\corecrt_wprocess.h" 
unicode-data.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\corecrt_wtime.h" 
unicode-data.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\sys/stat.h" 
unicode-data.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\sys/types.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\new" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\vcruntime_new.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\vcruntime.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\xutility" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\utility" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\iosfwd" 
unicode-data.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\crtdbg.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\vcruntime_new_debug.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\xatomic0.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\intrin.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\vcruntime.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\setjmp.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\vcruntime.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\immintrin.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\wmmintrin.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\nmmintrin.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\smmintrin.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\tmmintrin.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\pmmintrin.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\emmintrin.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\xmmintrin.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\mmintrin.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\ammintrin.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\typeinfo" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\vcruntime_typeinfo.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\vcruntime.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\xlocinfo" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\xlocinfo.h" 
unicode-data.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\ctype.h" 
unicode-data.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\locale.h" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\xfacet" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\system_error" 
unicode-data.obj : "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\INCLUDE\cerrno" 
unicode-data.obj : "C:\Program Files (x86)\Windows Kits\10\include\10.0.10240.0\ucrt\share.h" 
unicode-data.obj : "E:\xapian-1.2.23\xapian-core\common\omassert.h" 
