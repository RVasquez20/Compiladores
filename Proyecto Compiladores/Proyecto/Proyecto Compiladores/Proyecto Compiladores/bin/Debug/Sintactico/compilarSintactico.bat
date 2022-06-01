del .\Sintactico\lex.yy.c
del .\Sintactico\sintactic.tab.c
del .\Sintactico\sintactic.tab.h
flex .\Sintactico\lexicoEnlazadoBison.l
bison -d .\Sintactico\sintactic.y
move .\lex.yy.c .\Sintactico\
move .\sintactic.tab.c .\Sintactico\
move .\sintactic.tab.h .\Sintactico\
gcc -o compiladoBison.exe .\Sintactico\lex.yy.c .\Sintactico\sintactic.tab.c
move .\compiladoBison.exe .\Sintactico\