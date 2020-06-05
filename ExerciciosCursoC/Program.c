#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <locale.h>


void main() {

	//permite usar acentos
	setlocale(LC_ALL, "");

	for (int i = 0; i < 3; i++)
	{
		TiposDeVariaveis_2();
		printf("\n\n");
		printf("\n\n");
	}

	printf("\n\n");
	printf("\n\n");

}

int uri() {

	double n = 3.14159;
	double raio;
	scanf("%f", &raio);
	printf("A=%f\n", n * raio * raio);

}

int _1001() {

	int a = 0;
	int b = 0;
	scanf("%d", &a);
	scanf("%d", &b);
	printf("X = %d\n", a + b);
}

int TiposDeVariaveis_1()
{
	//imprime valor na tela
	printf("Olá Mundo!!!");

	printf("\n\n");

	int a = 0;
	int b = 0;

	printf("Digite o valor de 'a': ");
	scanf_s("%d", &a);

	printf("Digite o valor de 'b': ");
	scanf_s("%d", &b);

	printf("O valor de 'a' + 'b' é %d", a + b);
}

int TiposDeVariaveis_2() {

	//manipulando int
	int a = 50;
	printf("O valor de a é %d \n", a);
	scanf("%d", &a);
	printf("O valor de a mudou para %d \n\n", a);

	//manupulando float
	float b = 5.5;
	printf("O valor de b é %f \n", b);
	scanf("%f", &b);
	printf("O valor de f mudou para %f \n\n", b);

	//manipulando char
	char letra = 't';
	printf("O valor de c é %c \n", letra);
	fflush(stdin); //faz a limpeza do buffer/lixo
	scanf(" %c", &letra);
	printf("O valor de c mudou para %c \n\n", letra);
}
