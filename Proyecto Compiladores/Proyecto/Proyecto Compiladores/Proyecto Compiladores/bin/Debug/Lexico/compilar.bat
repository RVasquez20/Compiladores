del .\Lexico\Lexico.exe
del .\Lexico\lex.yy.c
flex .\Lexico\lexicoFlex.l
move .\lex.yy.c .\Lexico\
gcc .\Lexico\lex.yy.c -o Lexico.exe
move .\Lexico.exe .\Lexico\

