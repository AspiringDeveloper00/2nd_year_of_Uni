
#include <iostream>
#include <string>
#include <stack>
using namespace std;


	int main()
	{	
        string symbols;
		char a;
		char x;
		int posi = 0;
		int posj = 0;
		int s = 0;
		bool flag = false;
		stack <char> parser;
		char tableN[4] = { 'S','X','Y','Z' };
		char tableT[7] = { '(',')','*','+','-','a','b' };
		char syntaxtable[3][4][7];
		for (int i = 0; i < 3; i++)
		{
			for (int j = 0; j < 4; j++)
			{
				for (int k = 0; k < 7; k++)
				{
					syntaxtable[i][j][k] = '0';
				}
			}
		}

		syntaxtable[0][0][0] = { '(' };
		syntaxtable[1][0][0] = { 'X' };
		syntaxtable[2][0][0] = { ')' };

		syntaxtable[0][1][0] = { 'Y' };
		syntaxtable[1][1][0] = { 'Z' };

		syntaxtable[0][1][4] = { 'B' };
		syntaxtable[1][1][4] = { 'E' };

		syntaxtable[0][1][5] = { 'B' };
		syntaxtable[1][1][5] = { 'E' };

		syntaxtable[0][2][0] = { 'S' };
		syntaxtable[0][2][4] = { 'a' };
		syntaxtable[0][2][5] = { 'b' };
		syntaxtable[0][3][1] = { 'e' };

		syntaxtable[0][3][2] = { '*' };
		syntaxtable[1][3][2] = { 'X' };

		syntaxtable[0][3][3] = { '-' };
		syntaxtable[1][3][3] = { 'X' };
		
		syntaxtable[0][3][4] = { '+' };
		syntaxtable[1][3][4] = { 'X' };

		cout << " Give the string , please!\n";
		getline(cin, symbols);
		if (symbols[(symbols.length()-1)] != '$') symbols = symbols + '$';
		
		cout << "The syntax table of the given grammar looks something like this (in the shape of a 3d array)\n";
		for (int i = 0; i < 3; i++)
		{
			for (int j = 0; j < 4; j++)
			{
				for (int k = 0; k < 7; k++)
				{
					cout << "\t" << syntaxtable[i][j][k];
				}
				cout << "\n";
			}
			cout << "\n";
		}
		
		parser.push('$');
		parser.push('S');
	
		a = symbols[s];
		x = parser.top();

		while (flag == false)
		{
			if (a == '(' || a == ')' || a == '*' || a == '-' || a == '+'|| a == 'a' || a == 'b' || a == '$')
			{
				while (x == 'S' || x == 'X' || x == 'Y' || x == 'Z')
				{

					for (int i = 0;i < 4;i++)
					{
						if (tableN[i] == x) posi = i;

					}
					for (int i = 0;i < 7;i++)
					{
						if (tableT[i] == a) posj = i;

					}


					if (syntaxtable[0][posi][posj] == '0')
					{
						cout << "\n The string cannot be recognized ";
						flag = true;
						break;
					}
					else
					{
						cout << "\nsymbol : " << parser.top() << "\t exits the stack";
						parser.pop();

						for (int k = 2;k >= 0;k--)
						{
							if (syntaxtable[k][posi][posj] != '0' && syntaxtable[k][posi][posj] != 'e')
							{
								parser.push(syntaxtable[k][posi][posj]);
								cout  << "\nsymbol : " << syntaxtable[k][posi][posj] << "\t enters the stack";
							}
						}
						x = parser.top();
					}

				}

				if (a == '(' || a == ')' || a == '*' || a == '-' || a == '+'|| a == 'a' || a == 'b' || a == '$')
				{

					if (x == a)
					{
						if (x == '$')
						{
							cout << " \n The string has been successfully recognized ";
							flag = true;
						}
						else
						{
							cout << "\nsymbol : " << parser.top() << "\t exits the stack";
							parser.pop();
							x = parser.top();
							s = s + 1;
							if (s < symbols.length()) a = symbols[s];

							cout << "\nwe check the given symbol : " << symbols[s] << "\t and the top of the stack is : " << x;

						}

					}
					else 
			          { 
				         cout << "\n The string cannot be recognized ";
				         flag = true; 
			          }

				}

			}
			else 
			{ 
				cout << "\n The string cannot be recognized ";
				flag = true; 
			}

		}

    }
	
	
	
	
	

	
	
	
	
	
	
	
	
