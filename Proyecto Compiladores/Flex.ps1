del lex.yy.c
del y.tab.c
del y.tab.h
flex lexicoFlex.l
bison -d -y sintactic.y
gcc -o compiladoBison.exe lex.yy.c y.tab.c
.\compiladoBison.exe .\prueba.txt