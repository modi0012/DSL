// DslParser.cs - generated by the SLK parser generator

namespace Dsl.Parser
{

    static class DslParser
    {

private static short[] Production = {0

,2,42,43 ,3,43,44,92 ,3,44,61,123 ,3,45,62,123 ,3,46,63,123 
,3,47,64,123 ,3,48,65,123 ,3,49,66,123 ,3,50,67,123 
,3,51,68,123 ,3,52,69,123 ,3,53,70,123 ,3,54,71,123 
,3,55,72,123 ,3,56,73,123 ,3,57,74,123 ,3,58,75,123 
,3,59,76,123 ,3,60,77,123 ,3,61,62,93 ,3,62,63,94 
,3,63,64,95 ,3,64,65,96 ,3,65,66,97 ,3,66,67,98 
,3,67,68,99 ,3,68,69,100 ,3,69,70,101 ,3,70,71,102 
,3,71,72,103 ,3,72,73,104 ,3,73,74,105 ,3,74,75,106 
,3,75,76,107 ,3,76,77,108 ,3,77,79,109 ,3,78,79,123 
,3,79,129,80 ,2,80,110 ,5,80,130,82,131,111 ,4,81,90,132,112 
,2,82,83 ,6,83,133,18,43,19,113 ,6,83,135,20,43,21,114 
,5,83,136,22,84,115 ,5,83,137,23,85,116 ,6,83,137,138,24,43,19 
,6,83,137,139,25,43,21 ,6,83,137,140,26,43,27 ,5,83,141,28,86,117 
,5,83,136,29,87,118 ,5,83,137,30,88,119 ,5,83,141,31,89,120 
,6,83,142,32,43,27,121 ,5,83,143,33,144,122 ,8,84,145,129,130,90,146,131,123 
,5,84,147,18,43,19 ,5,84,148,20,43,21 ,5,84,149,32,43,27 
,8,85,150,129,130,90,146,131,123 ,8,86,151,129,130,90,146,131,123 
,8,87,152,129,130,90,146,131,123 ,8,88,153,129,130,90,146,131,123 
,8,89,154,129,130,90,146,131,123 ,3,90,34,125 ,3,90,35,155 
,3,90,36,156 ,3,90,37,157 ,3,90,38,158 ,2,91,39 ,2,91,40 
,4,92,91,44,92 ,1,92 ,7,93,124,1,125,126,45,93 ,1,93 
,7,94,124,2,125,126,46,94 ,1,94 ,7,95,124,3,125,126,47,95 
,1,95 ,11,96,124,4,125,127,48,4,125,128,48,96 ,1,96 
,7,97,124,5,125,126,49,97 ,1,97 ,7,98,124,6,125,126,50,98 
,1,98 ,7,99,124,7,125,126,51,99 ,1,99 ,7,100,124,8,125,126,52,100 
,1,100 ,7,101,124,9,125,126,53,101 ,1,101 ,7,102,124,10,125,126,54,102 
,1,102 ,7,103,124,11,125,126,55,103 ,1,103 ,7,104,124,12,125,126,56,104 
,1,104 ,7,105,124,13,125,126,57,105 ,1,105 ,7,106,124,14,125,126,58,106 
,1,106 ,7,107,124,15,125,126,59,107 ,1,107 ,7,108,124,16,125,126,60,108 
,1,108 ,7,109,124,17,125,126,78,109 ,1,109 ,5,110,130,81,131,110 
,1,110 ,5,111,130,81,131,111 ,1,111 ,2,112,83 ,1,112 ,3,113,134,83 
,1,113 ,3,114,134,83 ,1,114 ,3,115,134,83 ,1,115 ,3,116,134,83 
,1,116 ,3,117,134,83 ,1,117 ,3,118,134,83 ,1,118 ,3,119,134,83 
,1,119 ,3,120,134,83 ,1,120 ,3,121,134,83 ,1,121 ,3,122,134,83 
,1,122 
,0};

private static int[] Production_row = {0

,1,4,8,12,16,20,24,28,32,36,40,44,48,52,56,60
,64,68,72,76,80,84,88,92,96,100,104,108,112,116,120,124
,128,132,136,140,144,148,152,155,161,166,169,176,183,189,195,202
,209,216,222,228,234,240,247,253,262,268,274,280,289,298,307,316
,325,329,333,337,341,345,348,351,356,358,366,368,376,378,386,388
,400,402,410,412,420,422,430,432,440,442,450,452,460,462,470,472
,480,482,490,492,500,502,510,512,520,522,530,532,538,540,546,548
,551,553,557,559,563,565,569,571,575,577,581,583,587,589,593,595
,599,601,605,607,611
,0};

private static short[] Parse = {

0,0,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2
,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2
,2,2,2,2,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3
,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3
,3,3,3,3,3,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4
,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4
,4,4,4,4,4,4,5,5,5,5,5,5,5,5,5,5,5,5,5,5
,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5
,5,5,5,5,5,5,5,6,6,6,6,6,6,6,6,6,6,6,6,6
,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6
,6,6,6,6,6,6,6,6,7,7,7,7,7,7,7,7,7,7,7,7
,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7
,7,7,7,7,7,7,7,7,7,8,8,8,8,8,8,8,8,8,8,8
,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8
,8,8,8,8,8,8,8,8,8,8,9,9,9,9,9,9,9,9,9,9
,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9
,9,9,9,9,9,9,9,9,9,9,9,10,10,10,10,10,10,10,10,10
,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10
,10,10,10,10,10,10,10,10,10,10,10,10,11,11,11,11,11,11,11,11
,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11
,11,11,11,11,11,11,11,11,11,11,11,11,11,12,12,12,12,12,12,12
,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12
,12,12,12,12,12,12,12,12,12,12,12,12,12,12,13,13,13,13,13,13
,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13
,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,14,14,14,14,14
,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14
,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,15,15,15,15
,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15
,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,16,16,16
,16,16,16,16,16,16,16,16,16,16,16,16,16,16,16,16,16,16,16,16
,16,16,16,16,16,16,16,16,16,16,16,16,16,16,16,16,16,16,17,17
,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17
,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,18
,18,18,18,18,18,18,18,18,18,18,18,18,18,18,18,18,18,18,18,18
,18,18,18,18,18,18,18,18,18,18,18,18,18,18,18,18,18,18,18,18
,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19
,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19
,19,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20
,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20
,20,20,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21
,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21
,21,21,21,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22
,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22
,22,22,22,22,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23
,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23
,23,23,23,23,23,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24
,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24
,24,24,24,24,24,24,25,25,25,25,25,25,25,25,25,25,25,25,25,25
,25,25,25,25,25,25,25,25,25,25,25,25,25,25,25,25,25,25,25,25
,25,25,25,25,25,25,25,26,26,26,26,26,26,26,26,26,26,26,26,26
,26,26,26,26,26,26,26,26,26,26,26,26,26,26,26,26,26,26,26,26
,26,26,26,26,26,26,26,26,27,27,27,27,27,27,27,27,27,27,27,27
,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27
,27,27,27,27,27,27,27,27,27,28,28,28,28,28,28,28,28,28,28,28
,28,28,28,28,28,28,28,28,28,28,28,28,28,28,28,28,28,28,28,28
,28,28,28,28,28,28,28,28,28,28,29,29,29,29,29,29,29,29,29,29
,29,29,29,29,29,29,29,29,29,29,29,29,29,29,29,29,29,29,29,29
,29,29,29,29,29,29,29,29,29,29,29,30,30,30,30,30,30,30,30,30
,30,30,30,30,30,30,30,30,30,30,30,30,30,30,30,30,30,30,30,30
,30,30,30,30,30,30,30,30,30,30,30,30,31,31,31,31,31,31,31,31
,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31
,31,31,31,31,31,31,31,31,31,31,31,31,31,32,32,32,32,32,32,32
,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32
,32,32,32,32,32,32,32,32,32,32,32,32,32,32,33,33,33,33,33,33
,33,33,33,33,33,33,33,33,33,33,33,33,33,33,33,33,33,33,33,33
,33,33,33,33,33,33,33,33,33,33,33,33,33,33,33,34,34,34,34,34
,34,34,34,34,34,34,34,34,34,34,34,34,34,34,34,34,34,34,34,34
,34,34,34,34,34,34,34,34,34,34,34,34,34,34,34,34,35,35,35,35
,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35
,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,36,36,36
,36,36,36,36,36,36,36,36,36,36,36,36,36,36,36,36,36,36,36,36
,36,36,36,36,36,36,36,36,36,36,36,36,36,36,36,36,36,36,37,37
,37,37,37,37,37,37,37,37,37,37,37,37,37,37,37,37,37,37,37,37
,37,37,37,37,37,37,37,37,37,37,37,37,37,37,37,37,37,37,37,38
,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38
,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38
,39,39,39,39,39,39,39,39,39,39,39,39,39,39,39,39,39,40,39,40
,39,40,40,40,40,40,39,40,40,40,40,40,40,39,39,39,39,39,39,39
,39,113,113,113,113,113,113,113,113,113,113,113,113,113,113,113,113,113,112,113
,112,113,112,112,112,112,112,113,112,112,112,112,112,112,113,113,113,113,113,113
,113,113,115,115,115,115,115,115,115,115,115,115,115,115,115,115,115,115,115,114
,115,114,115,114,114,114,114,114,115,114,114,114,114,114,114,115,115,115,115,115
,115,115,115,117,117,117,117,117,117,117,117,117,117,117,117,117,117,117,117,117
,116,117,116,117,116,116,116,116,116,117,116,116,116,116,116,116,117,117,117,117
,117,117,117,117,119,119,119,119,119,119,119,119,119,119,119,119,119,119,119,119
,119,118,119,118,119,118,118,118,118,118,119,118,118,118,118,118,118,119,119,119
,119,119,119,119,119,121,121,121,121,121,121,121,121,121,121,121,121,121,121,121
,121,121,120,121,120,121,120,120,120,120,120,121,120,120,120,120,120,120,121,121
,121,121,121,121,121,121,123,123,123,123,123,123,123,123,123,123,123,123,123,123
,123,123,123,122,123,122,123,122,122,122,122,122,123,122,122,122,122,122,122,123
,123,123,123,123,123,123,123,125,125,125,125,125,125,125,125,125,125,125,125,125
,125,125,125,125,124,125,124,125,124,124,124,124,124,125,124,124,124,124,124,124
,125,125,125,125,125,125,125,125,127,127,127,127,127,127,127,127,127,127,127,127
,127,127,127,127,127,126,127,126,127,126,126,126,126,126,127,126,126,126,126,126
,126,127,127,127,127,127,127,127,127,129,129,129,129,129,129,129,129,129,129,129
,129,129,129,129,129,129,128,129,128,129,128,128,128,128,128,129,128,128,128,128
,128,128,129,129,129,129,129,129,129,129,131,131,131,131,131,131,131,131,131,131
,131,131,131,131,131,131,131,130,131,130,131,130,130,130,130,130,131,130,130,130
,130,130,130,131,131,131,131,131,131,131,131,133,133,133,133,133,133,133,133,133
,133,133,133,133,133,133,133,133,132,133,132,133,132,132,132,132,132,133,132,132
,132,132,132,132,133,133,133,133,133,133,133,133,1,1,1,1,1,1,1,1
,1,1,1,1,1,1,1,1,1,1,0,1,0,1,1,1,1,1,0,1
,1,1,1,1,1,1,1,1,1,1,1,1,1,109,109,109,109,109,109,109
,109,109,109,109,109,109,109,109,109,109,42,109,42,109,42,42,42,42,42,109
,42,42,42,42,42,42,108,108,108,108,108,109,109,109,111,111,111,111,111,111
,111,111,111,111,111,111,111,111,111,111,111,43,111,44,111,45,46,47,48,49
,111,50,51,52,53,54,55,110,110,110,110,110,111,111,111,107,107,107,107,107
,107,107,107,107,107,107,107,107,107,107,107,106,57,107,58,107,41,41,41,41
,41,107,70,71,0,0,59,0,56,56,56,56,56,107,107,107,105,105,105,105
,105,105,105,105,105,105,105,105,105,105,105,104,0,0,105,0,105,60,60,60
,60,60,105,61,61,61,61,61,62,62,62,62,62,0,105,105,105,103,103,103
,103,103,103,103,103,103,103,103,103,103,103,102,73,0,73,103,0,103,0,0
,73,0,0,103,63,63,63,63,63,0,0,0,72,72,73,103,103,103,101,101
,101,101,101,101,101,101,101,101,101,101,101,100,0,0,0,0,101,0,101,64
,64,64,64,64,101,65,66,67,68,69,0,0,0,0,77,76,101,101,101,99
,99,99,99,99,99,99,99,99,99,99,99,98,77,0,77,0,0,99,0,99
,77,0,0,0,0,99,0,0,0,0,0,0,77,77,77,0,0,99,99,99
,97,97,97,97,97,97,97,97,97,97,97,96,0,0,0,0,0,0,97,0
,97,0,0,0,0,0,97,95,95,95,95,95,95,95,95,95,95,94,97,97
,97,0,0,0,0,95,0,95,0,0,0,0,0,95,93,93,93,93,93,93
,93,93,93,92,0,95,95,95,0,0,0,0,93,0,93,0,0,0,0,0
,93,91,91,91,91,91,91,91,91,90,0,0,93,93,93,0,0,0,0,91
,0,91,0,0,79,79,78,91,89,89,89,89,89,89,89,88,0,0,0,91
,91,91,79,0,79,0,89,0,89,0,79,74,0,0,89,87,87,87,87,87
,87,86,79,79,79,0,89,89,89,75,0,75,0,87,0,87,0,75,0,0
,0,87,85,85,85,85,85,84,0,75,75,75,0,87,87,87,0,0,0,0
,85,0,85,0,0,0,0,0,85,83,83,83,83,82,81,81,81,80,0,0
,85,85,85,0,0,0,0,83,0,83,0,0,81,0,81,83,0,0,0,0
,81,0,0,0,0,0,0,83,83,83,0,0,81,81,81
};

private static int[] Parse_row = {0

,2010,1,42,83,124,165,206,247,288,329,370,411,452,493,534,575
,616,657,698,739,780,821,862,903,944,985,1026,1067,1108,1149,1190,1231
,1272,1313,1354,1395,1436,1477,1518,2121,2051,2092,2133,2162,2168,2173,2209,2244
,2250,2122,2212,2469,2292,2442,2532,2527,2500,2473,2446,2419,2392,2365,2338,2297
,2256,2215,2174,2133,2051,2092,1559,1600,1641,1682,1723,1764,1805,1846,1887,1928
,1969
,0};

private static short[] Conflict = {

0
};

private static int[] Conflict_row = {0


,0};

private static short get_conditional_production ( short symbol ) { return (short) 0; }

private const short   END_OF_SLK_INPUT_ = 41;
private const short   START_SYMBOL = 42;
private const short   START_STATE = 0;
private const short   START_CONFLICT = 134;
private const short   END_CONFLICT = 134;
private const short   START_ACTION = 123;
private const short   END_ACTION = 159;
private const short   TOTAL_CONFLICTS = 0;

public const int   NOT_A_SYMBOL = 0;
public const int   NONTERMINAL_SYMBOL = 1;
public const int   TERMINAL_SYMBOL = 2;
public const int   ACTION_SYMBOL = 3;

        internal static short[]
        GetProductionArray(short production_number)
        {
            short index = (short)Production_row[production_number],
                    array_length = (short)Production[index],
                    new_index = 0;
            short[] productionArray = new short[18];

            while (array_length-- >= 0) {
                productionArray[new_index++] = Production[index++];
            }
            return productionArray;
        }

        internal static int GetSymbolType(short symbol)
        {
            int symbol_type = NOT_A_SYMBOL;

            if (symbol >= START_ACTION && symbol < END_ACTION) {
                symbol_type = ACTION_SYMBOL;
            } else if (symbol >= START_SYMBOL) {
                symbol_type = NONTERMINAL_SYMBOL;
            } else if (symbol > 0) {
                symbol_type = TERMINAL_SYMBOL;
            }
            return symbol_type;
        }

        internal static bool IsNonterminal(short symbol)
        {
            return (symbol >= START_SYMBOL && symbol < START_ACTION);
        }

        internal static bool IsTerminal(short symbol)
        {
            return (symbol > 0 && symbol < START_SYMBOL);
        }

        internal static bool IsAction(short symbol)
        {
            return (symbol >= START_ACTION && symbol < END_ACTION);
        }

        internal static short GetTerminalIndex(short token)
        {
            return (token);
        }

        internal static short
        get_production(short conflict_number,
                         DslToken tokens)
        {
            short entry = 0;
            int index, level;

            if (conflict_number <= TOTAL_CONFLICTS) {
                entry = (short)(conflict_number + (START_CONFLICT - 1));
                level = 1;
                while (entry >= START_CONFLICT) {
                    index = Conflict_row[entry - (START_CONFLICT - 1)];
                    index += tokens.peek(level);
                    entry = Conflict[index];
                    ++level;
                }
            }

            return entry;
        }

        private static short
        get_predicted_entry(DslToken tokens,
                              short production_number,
                              short token,
                              int scan_level,
                              int depth)
        {
            return 0;
        }

        internal unsafe static void
        parse(ref DslAction action,
                ref DslToken tokens,
                ref DslError error,
                short start_symbol)
        {
            short rhs, lhs;
            short production_number, entry, symbol, token, new_token;
            int production_length, top, index, level;
            
            short* stack = stackalloc short[65535];

            top = 65534;
            stack[top] = 0;
            if (start_symbol == 0) {
                start_symbol = START_SYMBOL;
            }
            if (top > 0) {
                stack[--top] = start_symbol;
            } else { error.message("DslParse: stack overflow\n", ref tokens); return; }
            token = tokens.get();
            new_token = token;

            for (symbol = (stack[top] != 0 ? stack[top++] : (short)0); symbol != 0; ) {

                if (symbol >= START_ACTION) {
                    action.execute(symbol - (START_ACTION - 1));

                } else if (symbol >= START_SYMBOL) {
                    entry = 0;
                    level = 1;
                    production_number = get_conditional_production(symbol);
                    if (production_number != 0) {
                        entry = get_predicted_entry(tokens,
                                                      production_number, token,
                                                      level, 1);
                    }
                    if (entry == 0) {
                        index = Parse_row[symbol - (START_SYMBOL - 1)];
                        index += token;
                        entry = Parse[index];
                    }
                    while (entry >= START_CONFLICT) {
                        index = Conflict_row[entry - (START_CONFLICT - 1)];
                        index += tokens.peek(level);
                        entry = Conflict[index];
                        ++level;
                    }
                    if (entry != 0) {
                        index = Production_row[entry];
                        production_length = Production[index] - 1;
                        lhs = Production[++index];
                        if (lhs == symbol) {
                            action.predict(entry);
                            index += production_length;
                            for (; production_length-- > 0; --index) {
                                if (top > 0) {
                                    stack[--top] = Production[index];
                                } else { error.message("DslParse: stack overflow\n", ref tokens); return; }
                            }
                        } else {
                            new_token = error.no_entry(symbol, token, level - 1, ref tokens);
                        }
                    } else {                                       // no table entry
                        new_token = error.no_entry(symbol, token, level - 1, ref tokens);
                    }
                } else if (symbol > 0) {
                    if (symbol == token) {
                        token = tokens.get();
                        new_token = token;
                    } else {
                        new_token = error.mismatch(symbol, token, ref tokens);
                    }
                } else {
                    error.message("\n parser error: symbol value 0\n", ref tokens);
                }
                if (token != new_token) {
                    if (new_token != 0) {
                        token = new_token;
                    }
                    if (token != END_OF_SLK_INPUT_) {
                        continue;
                    }
                }
                symbol = (stack[top] != 0 ? stack[top++] : (short)0);
            }
            if (token != END_OF_SLK_INPUT_) {
                error.input_left(ref tokens);
            }
        }
    };
}
