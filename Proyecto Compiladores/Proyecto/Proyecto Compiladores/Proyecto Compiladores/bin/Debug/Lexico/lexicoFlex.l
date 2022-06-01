%{
#include <stdio.h>
#include <stdlib.h>
int nlines=0;
 void yyerror (char const *s){
    fprintf (stderr, "%s\n", s);
 }
%}
%option noyywrap
DIGITO [0-9]
DECIMAL [0-9]+"."[0-9]+
ID [a-zA-Z][a-zA-Z0-9_]*
%%
{DIGITO}+ {printf("TKN_NUM_ENTERO: %d \n",atoi(yytext));}
{DECIMAL} {printf("TKN_NUM_REAL: %5.2f \n",atof(yytext));}
"=" {printf("TKN_ASIGN: %s \n",yytext);}
";" {printf("TKN_PTOCOMA: %s \n",yytext);}
"*" {printf("TKN_MULT: %s \n",yytext);}
"/" {printf("TKN_DIV: %s \n",yytext);}
"+" {printf("TKN_MAS: %s \n",yytext);}
"-" {printf("TKN_MENOS: %s \n",yytext);}
"(" {printf("TKN_PAA: %s \n",yytext);}
")" {printf("TKN_PAC: %s \n",yytext);}
"^" {printf("TKN_POT: %s \n",yytext);}
"SQRT"|"sqrt" {printf("TKN_RAIZ: %s \n",yytext);}
"COS"|"Cos"|"cos" {printf("TKN_COS: %s \n",yytext);}
"SEN"|"Sen"|"sen" {printf("TKN_SEN: %s \n",yytext);}
"Tan"|"Tan"|"tan" {printf("TKN_TAN: %s \n",yytext);}
{ID} {printf("TKN_ID: %s \n",yytext);}
"\n" {nlines++;}
%%
void main(int argc,char **argv)
{
if (argc>1)
 yyin=fopen(argv[1],"r");
else
 yyin=stdin;
yylex();
printf("\nNumero lineas analizadas: %d \n", (nlines+1));
}
