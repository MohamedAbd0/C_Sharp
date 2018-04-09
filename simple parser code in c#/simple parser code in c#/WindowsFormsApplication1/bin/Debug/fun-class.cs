
using System;
using System.IO;
using System.Runtime.Serialization;
using com.calitha.goldparser.lalr;
using com.calitha.commons;

namespace com.calitha.goldparser
{

    [Serializable()]
    public class SymbolException : System.Exception
    {
        public SymbolException(string message) : base(message)
        {
        }

        public SymbolException(string message,
            Exception inner) : base(message, inner)
        {
        }

        protected SymbolException(SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }

    }

    [Serializable()]
    public class RuleException : System.Exception
    {

        public RuleException(string message) : base(message)
        {
        }

        public RuleException(string message,
                             Exception inner) : base(message, inner)
        {
        }

        protected RuleException(SerializationInfo info,
                                StreamingContext context) : base(info, context)
        {
        }

    }

    enum SymbolConstants : int
    {
        SYMBOL_EOF             =  0, // (EOF)
        SYMBOL_ERROR           =  1, // (Error)
        SYMBOL_WHITESPACE      =  2, // Whitespace
        SYMBOL_MINUS           =  3, // '-'
        SYMBOL_MINUSMINUS      =  4, // '--'
        SYMBOL_EXCLAMEQ        =  5, // '!='
        SYMBOL_PERCENT         =  6, // '%'
        SYMBOL_LPAREN          =  7, // '('
        SYMBOL_RPAREN          =  8, // ')'
        SYMBOL_TIMES           =  9, // '*'
        SYMBOL_COMMA           = 10, // ','
        SYMBOL_DIV             = 11, // '/'
        SYMBOL_COLON           = 12, // ':'
        SYMBOL_SEMI            = 13, // ';'
        SYMBOL_LBRACE          = 14, // '{'
        SYMBOL_RBRACE          = 15, // '}'
        SYMBOL_PLUS            = 16, // '+'
        SYMBOL_PLUSPLUS        = 17, // '++'
        SYMBOL_LT              = 18, // '<'
        SYMBOL_LTEQ            = 19, // '<='
        SYMBOL_EQ              = 20, // '='
        SYMBOL_EQEQ            = 21, // '=='
        SYMBOL_GT              = 22, // '>'
        SYMBOL_GTEQ            = 23, // '>='
        SYMBOL_BREAK           = 24, // break
        SYMBOL_CASE            = 25, // case
        SYMBOL_CHAR            = 26, // char
        SYMBOL_CLASS           = 27, // class
        SYMBOL_DEFAULT         = 28, // default
        SYMBOL_DO              = 29, // do
        SYMBOL_DOUBLE          = 30, // double
        SYMBOL_ELSE            = 31, // else
        SYMBOL_FOR             = 32, // for
        SYMBOL_IDENTIFIER      = 33, // Identifier
        SYMBOL_IF              = 34, // if
        SYMBOL_INT             = 35, // int
        SYMBOL_NUM             = 36, // Num
        SYMBOL_PRIVATE         = 37, // private
        SYMBOL_PUBLIC          = 38, // public
        SYMBOL_RETURN          = 39, // return
        SYMBOL_STRING          = 40, // string
        SYMBOL_SWITCH          = 41, // switch
        SYMBOL_THEN            = 42, // then
        SYMBOL_VOID            = 43, // void
        SYMBOL_WHILE           = 44, // while
        SYMBOL_ACCESMINUSMOD   = 45, // <acces-mod>
        SYMBOL_ASSIGN          = 46, // <assign>
        SYMBOL_BODY            = 47, // <body>
        SYMBOL_CASES           = 48, // <cases>
        SYMBOL_CLASSMINUSSTMT  = 49, // <class-stmt>
        SYMBOL_CONST           = 50, // <const>
        SYMBOL_EXPR            = 51, // <expr>
        SYMBOL_FACTOR          = 52, // <factor>
        SYMBOL_FORMINUSSTMT    = 53, // <for-stmt>
        SYMBOL_FUNMINUSSTMT    = 54, // <fun-stmt>
        SYMBOL_IFMINUSSTMT     = 55, // <if-stmt>
        SYMBOL_INC             = 56, // <inc>
        SYMBOL_LITERAL         = 57, // <literal>
        SYMBOL_LOGICMINUSEXPR  = 58, // <logic-expr>
        SYMBOL_OP              = 59, // <op>
        SYMBOL_PARM            = 60, // <parm>
        SYMBOL_PROG            = 61, // <prog>
        SYMBOL_STMT            = 62, // <stmt>
        SYMBOL_STMTMINUSLIST   = 63, // <stmt-list>
        SYMBOL_SWITCHMINUSCASE = 64, // <switch-case>
        SYMBOL_TERM            = 65, // <term>
        SYMBOL_TYPES           = 66, // <types>
        SYMBOL_VARIABLE        = 67, // <variable>
        SYMBOL_WHILEMINUSSTMT  = 68  // <while-stmt>
    };

    enum RuleConstants : int
    {
        RULE_PROG_LBRACE_RBRACE                                                     =  0, // <prog> ::= '{' <stmt-list> '}'
        RULE_STMTLIST_SEMI                                                          =  1, // <stmt-list> ::= <stmt> ';'
        RULE_STMTLIST_SEMI2                                                         =  2, // <stmt-list> ::= <stmt> ';' <stmt-list>
        RULE_STMT                                                                   =  3, // <stmt> ::= <assign>
        RULE_STMT2                                                                  =  4, // <stmt> ::= <if-stmt>
        RULE_STMT3                                                                  =  5, // <stmt> ::= <switch-case>
        RULE_STMT4                                                                  =  6, // <stmt> ::= <for-stmt>
        RULE_STMT5                                                                  =  7, // <stmt> ::= <while-stmt>
        RULE_STMT6                                                                  =  8, // <stmt> ::= <fun-stmt>
        RULE_STMT7                                                                  =  9, // <stmt> ::= <class-stmt>
        RULE_ASSIGN_IDENTIFIER_EQ                                                   = 10, // <assign> ::= Identifier '=' <expr>
        RULE_EXPR_PLUS                                                              = 11, // <expr> ::= <term> '+' <expr>
        RULE_EXPR_MINUS                                                             = 12, // <expr> ::= <term> '-' <expr>
        RULE_EXPR                                                                   = 13, // <expr> ::= <term>
        RULE_TERM_TIMES                                                             = 14, // <term> ::= <factor> '*' <term>
        RULE_TERM_DIV                                                               = 15, // <term> ::= <factor> '/' <term>
        RULE_TERM_PERCENT                                                           = 16, // <term> ::= <factor> '%' <term>
        RULE_TERM                                                                   = 17, // <term> ::= <factor>
        RULE_FACTOR_LPAREN_RPAREN                                                   = 18, // <factor> ::= '(' <expr> ')'
        RULE_FACTOR_IDENTIFIER                                                      = 19, // <factor> ::= Identifier
        RULE_FACTOR_NUM                                                             = 20, // <factor> ::= Num
        RULE_LOGICEXPR                                                              = 21, // <logic-expr> ::= <expr> <op> <expr>
        RULE_OP_LT                                                                  = 22, // <op> ::= '<'
        RULE_OP_GT                                                                  = 23, // <op> ::= '>'
        RULE_OP_LTEQ                                                                = 24, // <op> ::= '<='
        RULE_OP_GTEQ                                                                = 25, // <op> ::= '>='
        RULE_OP_EQEQ                                                                = 26, // <op> ::= '=='
        RULE_OP_EXCLAMEQ                                                            = 27, // <op> ::= '!='
        RULE_IFSTMT_IF_LPAREN_RPAREN_THEN_LBRACE_RBRACE                             = 28, // <if-stmt> ::= if '(' <logic-expr> ')' then '{' <stmt-list> '}'
        RULE_IFSTMT_IF_LPAREN_RPAREN_THEN_LBRACE_RBRACE_ELSE_LBRACE_RBRACE          = 29, // <if-stmt> ::= if '(' <logic-expr> ')' then '{' <stmt-list> '}' else '{' <stmt-list> '}'
        RULE_SWITCHCASE_SWITCH_LPAREN_IDENTIFIER_RPAREN_LBRACE_DEFAULT_COLON_RBRACE = 30, // <switch-case> ::= switch '(' Identifier ')' '{' <cases> default ':' <stmt-list> '}'
        RULE_CASES_CASE_COLON_BREAK_SEMI                                            = 31, // <cases> ::= case <literal> ':' <stmt-list> break ';'
        RULE_CASES_CASE_COLON_BREAK_SEMI2                                           = 32, // <cases> ::= case <literal> ':' <stmt-list> break ';' <cases>
        RULE_LITERAL_IDENTIFIER                                                     = 33, // <literal> ::= Identifier
        RULE_LITERAL_NUM                                                            = 34, // <literal> ::= Num
        RULE_FORSTMT_FOR_LPAREN_SEMI_SEMI_RPAREN_LBRACE_RBRACE                      = 35, // <for-stmt> ::= for '(' <types> <assign> ';' <logic-expr> ';' <inc> ')' '{' <stmt-list> '}'
        RULE_TYPES_INT                                                              = 36, // <types> ::= int
        RULE_TYPES_DOUBLE                                                           = 37, // <types> ::= double
        RULE_TYPES_STRING                                                           = 38, // <types> ::= string
        RULE_TYPES_CHAR                                                             = 39, // <types> ::= char
        RULE_INC_IDENTIFIER_PLUSPLUS                                                = 40, // <inc> ::= Identifier '++'
        RULE_INC_IDENTIFIER_MINUSMINUS                                              = 41, // <inc> ::= Identifier '--'
        RULE_WHILESTMT_DO_LPAREN_RPAREN_WHILE_LPAREN_RPAREN                         = 42, // <while-stmt> ::= do '(' <stmt-list> ')' while '(' <logic-expr> ')'
        RULE_WHILESTMT_WHILE_LPAREN_RPAREN_THEN                                     = 43, // <while-stmt> ::= while '(' <logic-expr> ')' then <stmt-list>
        RULE_FUNSTMT_IDENTIFIER_LPAREN_RPAREN_LBRACE_RETURN_RBRACE                  = 44, // <fun-stmt> ::= <acces-mod> <types> Identifier '(' <parm> ')' '{' return <stmt-list> '}'
        RULE_FUNSTMT_IDENTIFIER_LPAREN_RPAREN_LBRACE_RETURN_RBRACE2                 = 45, // <fun-stmt> ::= <acces-mod> <types> Identifier '(' ')' '{' return <stmt-list> '}'
        RULE_FUNSTMT_VOID_IDENTIFIER_LPAREN_RPAREN_LBRACE_RBRACE                    = 46, // <fun-stmt> ::= <acces-mod> void Identifier '(' ')' '{' <stmt-list> '}'
        RULE_FUNSTMT_VOID_IDENTIFIER_LPAREN_RPAREN_LBRACE_RBRACE2                   = 47, // <fun-stmt> ::= <acces-mod> void Identifier '(' <parm> ')' '{' <stmt-list> '}'
        RULE_ACCESMOD_PUBLIC                                                        = 48, // <acces-mod> ::= public
        RULE_ACCESMOD_PRIVATE                                                       = 49, // <acces-mod> ::= private
        RULE_PARM_IDENTIFIER                                                        = 50, // <parm> ::= <types> Identifier
        RULE_PARM_IDENTIFIER_COMMA                                                  = 51, // <parm> ::= <types> Identifier ',' <parm>
        RULE_CLASSSTMT_CLASS_IDENTIFIER_LPAREN_RPAREN_LBRACE_RBRACE                 = 52, // <class-stmt> ::= <acces-mod> class Identifier '(' ')' '{' <body> '}'
        RULE_BODY                                                                   = 53, // <body> ::= <variable> <const> <fun-stmt>
        RULE_BODY2                                                                  = 54, // <body> ::= <variable> <fun-stmt>
        RULE_BODY3                                                                  = 55, // <body> ::= <variable>
        RULE_BODY4                                                                  = 56, // <body> ::= <fun-stmt>
        RULE_VARIABLE_IDENTIFIER_SEMI                                               = 57, // <variable> ::= <types> Identifier ';'
        RULE_CONST_PUBLIC_IDENTIFIER_LPAREN_RPAREN_LBRACE_RBRACE                    = 58  // <const> ::= public Identifier '(' <parm> ')' '{' <assign> '}'
    };

    public class MyParser
    {
        private LALRParser parser;

        public MyParser(string filename)
        {
            FileStream stream = new FileStream(filename,
                                               FileMode.Open, 
                                               FileAccess.Read, 
                                               FileShare.Read);
            Init(stream);
            stream.Close();
        }

        public MyParser(string baseName, string resourceName)
        {
            byte[] buffer = ResourceUtil.GetByteArrayResource(
                System.Reflection.Assembly.GetExecutingAssembly(),
                baseName,
                resourceName);
            MemoryStream stream = new MemoryStream(buffer);
            Init(stream);
            stream.Close();
        }

        public MyParser(Stream stream)
        {
            Init(stream);
        }

        private void Init(Stream stream)
        {
            CGTReader reader = new CGTReader(stream);
            parser = reader.CreateNewParser();
            parser.TrimReductions = false;
            parser.StoreTokens = LALRParser.StoreTokensMode.NoUserObject;

            parser.OnTokenError += new LALRParser.TokenErrorHandler(TokenErrorEvent);
            parser.OnParseError += new LALRParser.ParseErrorHandler(ParseErrorEvent);
        }

        public void Parse(string source)
        {
            NonterminalToken token = parser.Parse(source);
            if (token != null)
            {
                Object obj = CreateObject(token);
                //todo: Use your object any way you like
            }
        }

        private Object CreateObject(Token token)
        {
            if (token is TerminalToken)
                return CreateObjectFromTerminal((TerminalToken)token);
            else
                return CreateObjectFromNonterminal((NonterminalToken)token);
        }

        private Object CreateObjectFromTerminal(TerminalToken token)
        {
            switch (token.Symbol.Id)
            {
                case (int)SymbolConstants.SYMBOL_EOF :
                //(EOF)
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ERROR :
                //(Error)
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_WHITESPACE :
                //Whitespace
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MINUS :
                //'-'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MINUSMINUS :
                //'--'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EXCLAMEQ :
                //'!='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PERCENT :
                //'%'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LPAREN :
                //'('
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RPAREN :
                //')'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TIMES :
                //'*'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_COMMA :
                //','
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DIV :
                //'/'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_COLON :
                //':'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_SEMI :
                //';'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LBRACE :
                //'{'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RBRACE :
                //'}'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PLUS :
                //'+'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PLUSPLUS :
                //'++'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LT :
                //'<'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LTEQ :
                //'<='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EQ :
                //'='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EQEQ :
                //'=='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_GT :
                //'>'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_GTEQ :
                //'>='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_BREAK :
                //break
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CASE :
                //case
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CHAR :
                //char
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CLASS :
                //class
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DEFAULT :
                //default
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DO :
                //do
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DOUBLE :
                //double
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ELSE :
                //else
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_FOR :
                //for
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_IDENTIFIER :
                //Identifier
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_IF :
                //if
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_INT :
                //int
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_NUM :
                //Num
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PRIVATE :
                //private
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PUBLIC :
                //public
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RETURN :
                //return
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_STRING :
                //string
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_SWITCH :
                //switch
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_THEN :
                //then
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_VOID :
                //void
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_WHILE :
                //while
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ACCESMINUSMOD :
                //<acces-mod>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ASSIGN :
                //<assign>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_BODY :
                //<body>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CASES :
                //<cases>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CLASSMINUSSTMT :
                //<class-stmt>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CONST :
                //<const>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EXPR :
                //<expr>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_FACTOR :
                //<factor>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_FORMINUSSTMT :
                //<for-stmt>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_FUNMINUSSTMT :
                //<fun-stmt>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_IFMINUSSTMT :
                //<if-stmt>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_INC :
                //<inc>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LITERAL :
                //<literal>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LOGICMINUSEXPR :
                //<logic-expr>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_OP :
                //<op>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PARM :
                //<parm>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PROG :
                //<prog>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_STMT :
                //<stmt>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_STMTMINUSLIST :
                //<stmt-list>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_SWITCHMINUSCASE :
                //<switch-case>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TERM :
                //<term>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TYPES :
                //<types>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_VARIABLE :
                //<variable>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_WHILEMINUSSTMT :
                //<while-stmt>
                //todo: Create a new object that corresponds to the symbol
                return null;

            }
            throw new SymbolException("Unknown symbol");
        }

        public Object CreateObjectFromNonterminal(NonterminalToken token)
        {
            switch (token.Rule.Id)
            {
                case (int)RuleConstants.RULE_PROG_LBRACE_RBRACE :
                //<prog> ::= '{' <stmt-list> '}'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STMTLIST_SEMI :
                //<stmt-list> ::= <stmt> ';'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STMTLIST_SEMI2 :
                //<stmt-list> ::= <stmt> ';' <stmt-list>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STMT :
                //<stmt> ::= <assign>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STMT2 :
                //<stmt> ::= <if-stmt>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STMT3 :
                //<stmt> ::= <switch-case>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STMT4 :
                //<stmt> ::= <for-stmt>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STMT5 :
                //<stmt> ::= <while-stmt>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STMT6 :
                //<stmt> ::= <fun-stmt>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STMT7 :
                //<stmt> ::= <class-stmt>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ASSIGN_IDENTIFIER_EQ :
                //<assign> ::= Identifier '=' <expr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EXPR_PLUS :
                //<expr> ::= <term> '+' <expr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EXPR_MINUS :
                //<expr> ::= <term> '-' <expr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EXPR :
                //<expr> ::= <term>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TERM_TIMES :
                //<term> ::= <factor> '*' <term>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TERM_DIV :
                //<term> ::= <factor> '/' <term>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TERM_PERCENT :
                //<term> ::= <factor> '%' <term>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TERM :
                //<term> ::= <factor>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_FACTOR_LPAREN_RPAREN :
                //<factor> ::= '(' <expr> ')'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_FACTOR_IDENTIFIER :
                //<factor> ::= Identifier
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_FACTOR_NUM :
                //<factor> ::= Num
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_LOGICEXPR :
                //<logic-expr> ::= <expr> <op> <expr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OP_LT :
                //<op> ::= '<'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OP_GT :
                //<op> ::= '>'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OP_LTEQ :
                //<op> ::= '<='
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OP_GTEQ :
                //<op> ::= '>='
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OP_EQEQ :
                //<op> ::= '=='
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OP_EXCLAMEQ :
                //<op> ::= '!='
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_IFSTMT_IF_LPAREN_RPAREN_THEN_LBRACE_RBRACE :
                //<if-stmt> ::= if '(' <logic-expr> ')' then '{' <stmt-list> '}'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_IFSTMT_IF_LPAREN_RPAREN_THEN_LBRACE_RBRACE_ELSE_LBRACE_RBRACE :
                //<if-stmt> ::= if '(' <logic-expr> ')' then '{' <stmt-list> '}' else '{' <stmt-list> '}'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_SWITCHCASE_SWITCH_LPAREN_IDENTIFIER_RPAREN_LBRACE_DEFAULT_COLON_RBRACE :
                //<switch-case> ::= switch '(' Identifier ')' '{' <cases> default ':' <stmt-list> '}'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CASES_CASE_COLON_BREAK_SEMI :
                //<cases> ::= case <literal> ':' <stmt-list> break ';'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CASES_CASE_COLON_BREAK_SEMI2 :
                //<cases> ::= case <literal> ':' <stmt-list> break ';' <cases>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_LITERAL_IDENTIFIER :
                //<literal> ::= Identifier
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_LITERAL_NUM :
                //<literal> ::= Num
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_FORSTMT_FOR_LPAREN_SEMI_SEMI_RPAREN_LBRACE_RBRACE :
                //<for-stmt> ::= for '(' <types> <assign> ';' <logic-expr> ';' <inc> ')' '{' <stmt-list> '}'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TYPES_INT :
                //<types> ::= int
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TYPES_DOUBLE :
                //<types> ::= double
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TYPES_STRING :
                //<types> ::= string
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TYPES_CHAR :
                //<types> ::= char
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_INC_IDENTIFIER_PLUSPLUS :
                //<inc> ::= Identifier '++'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_INC_IDENTIFIER_MINUSMINUS :
                //<inc> ::= Identifier '--'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_WHILESTMT_DO_LPAREN_RPAREN_WHILE_LPAREN_RPAREN :
                //<while-stmt> ::= do '(' <stmt-list> ')' while '(' <logic-expr> ')'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_WHILESTMT_WHILE_LPAREN_RPAREN_THEN :
                //<while-stmt> ::= while '(' <logic-expr> ')' then <stmt-list>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_FUNSTMT_IDENTIFIER_LPAREN_RPAREN_LBRACE_RETURN_RBRACE :
                //<fun-stmt> ::= <acces-mod> <types> Identifier '(' <parm> ')' '{' return <stmt-list> '}'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_FUNSTMT_IDENTIFIER_LPAREN_RPAREN_LBRACE_RETURN_RBRACE2 :
                //<fun-stmt> ::= <acces-mod> <types> Identifier '(' ')' '{' return <stmt-list> '}'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_FUNSTMT_VOID_IDENTIFIER_LPAREN_RPAREN_LBRACE_RBRACE :
                //<fun-stmt> ::= <acces-mod> void Identifier '(' ')' '{' <stmt-list> '}'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_FUNSTMT_VOID_IDENTIFIER_LPAREN_RPAREN_LBRACE_RBRACE2 :
                //<fun-stmt> ::= <acces-mod> void Identifier '(' <parm> ')' '{' <stmt-list> '}'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ACCESMOD_PUBLIC :
                //<acces-mod> ::= public
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ACCESMOD_PRIVATE :
                //<acces-mod> ::= private
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_PARM_IDENTIFIER :
                //<parm> ::= <types> Identifier
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_PARM_IDENTIFIER_COMMA :
                //<parm> ::= <types> Identifier ',' <parm>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CLASSSTMT_CLASS_IDENTIFIER_LPAREN_RPAREN_LBRACE_RBRACE :
                //<class-stmt> ::= <acces-mod> class Identifier '(' ')' '{' <body> '}'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_BODY :
                //<body> ::= <variable> <const> <fun-stmt>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_BODY2 :
                //<body> ::= <variable> <fun-stmt>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_BODY3 :
                //<body> ::= <variable>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_BODY4 :
                //<body> ::= <fun-stmt>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_VARIABLE_IDENTIFIER_SEMI :
                //<variable> ::= <types> Identifier ';'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CONST_PUBLIC_IDENTIFIER_LPAREN_RPAREN_LBRACE_RBRACE :
                //<const> ::= public Identifier '(' <parm> ')' '{' <assign> '}'
                //todo: Create a new object using the stored tokens.
                return null;

            }
            throw new RuleException("Unknown rule");
        }

        private void TokenErrorEvent(LALRParser parser, TokenErrorEventArgs args)
        {
            string message = "Token error with input: '"+args.Token.ToString()+"'";
            //todo: Report message to UI?
        }

        private void ParseErrorEvent(LALRParser parser, ParseErrorEventArgs args)
        {
            string message = "Parse error caused by token: '"+args.UnexpectedToken.ToString()+"'";
            //todo: Report message to UI?
        }

    }
}
