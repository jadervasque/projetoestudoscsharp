#define _CRT_SECURE_NO_WARNINGS
#include <locale.h>

// bibliotecas exclusivas do c++
#include <iostream>
#include <string>

using namespace std;

void aula();

int main() {

	//permite usar acentos

	int qtdRepeticoes = 3;
	//printf("Digite a quantidade de repetições: ");
	//qtdRepeticoes = scanf("%d", &qtdRepeticoes);

	printf("\n\n");
	for (int i = 0; i < qtdRepeticoes; i++) {
		//uri();
		setlocale(LC_ALL, "");
		aula();
		printf("\n\n");
	}
	//pausa o programa após executar
	//system("pause");

	return 0;
}

//a37
void aula() {

	string palavra;
	printf("Digite uma palavra: ");
	cin >> palavra;
	cout << palavra;
}