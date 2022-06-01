%{
#include <stdio.h>
#include <stdlib.h>
#include "sintactic.tab.h"
int nlines=1;
%}
NUMERO [0-9]+("."[0-9]+)?
ID [a-zA-Z][a-zA-Z0-9_]*
%option noyywrap
%%
{NUMERO}   {yylval.real = atof(yytext); return(TKN_NUM);}
"="         {return TKN_ASIGN ;}
";"         {return TKN_PTOCOMA ;}
"*"         {return TKN_MULT ;}
"/"         {return TKN_DIV ;}
"+"         {return TKN_MAS ;}
"-"         {return TKN_MENOS ;}
"("         {return TKN_PAA ;}
")"         {return TKN_PAC ;}
"^"         {return TKN_POT ;}
"SQRT"|"sqrt"       {return TKN_RAIZ ;}
"COS"|"Cos"|"cos"   {return TKN_COS ;}
"SEN"|"Sen"|"sen"   {return TKN_SEN ;}
"TAN"|"Tan"|"tan"   {return TKN_TAN ;}
{ID}                 {return TKN_ID ;}
"\n"              {nlines++;}
.
%%
