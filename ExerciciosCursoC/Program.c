#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <locale.h>


void main() {

	//permite usar acentos
	setlocale(LC_ALL, "");

	int qtdRepeticoes = 1;
	//printf("Digite a quantidade de repeti��es: ");
	//qtdRepeticoes = scanf("%d", &qtdRepeticoes);

	printf("\n\n");
	for (int i = 0; i < qtdRepeticoes; i++)
	{
		aula();
		printf("\n\n");
	}
	//pausa o programa ap�s executar
	system("pause");
}

int aula() {



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

int a18_ExercicioFixacao() {

	// Leia um algoritmo que leia 3 n�meros inteiros de uma s� vez e 
	// coloque o resultado da multiplica��o entre os 3 em uma v�riavel pr�ria,
	// depois exibir essa vari�vel

	int a, b, c, resultado;
	printf("Digite tr�s n�meros inteiros separados por espa�o: ");
	scanf("%d %d %d", &a, &b, &c);
	printf("\n\n");
	resultado = a * b * c;
	printf("O resultado da multiplica��o de %d, %d e %d = %d.", a, b, c, resultado);

}

int a16_ExercicioFixacao() {

	// Leia 2 notas e mostre o valor absoluto da diferen�a entre elas

	float a, b, resultado;

	printf("Entre com o valor a: ");
	scanf("%f", &a);
	printf("\n\n");

	printf("Entre com o valor b: ");
	scanf("%f", &b);
	printf("\n\n");

	resultado = abs(a - b);
	printf("O valor absoluto de %.2f - %.2f = %.2f", a, b, resultado);

}

int a14_ExercicioFixacao() {

	//Leia duas notas e apresente a m�dia

	float a, b;
	printf("Digite o valor da m�dia 'a': ");
	scanf("%f", &a);

	printf("\n\n");
	printf("Digite o valor da m�dia 'b': ");
	scanf("%f", &b);

	printf("\n\n");
	printf("O valor da m�dia de %f e %f = %f.", a, b, (a + b) / 2);

}

int a11_OperacoesMatematicas() {

	int a = 5, b = 3;

	//soma
	printf("A soma de %d e %d = %d \n", a, b, a + b);

	//subtra��o
	printf("A subtra��o de %d e %d = %d \n", a, b, a - b);

	//multiplica��o
	printf("A multiplica��o de %d e %d = %d \n", a, b, a * b);

	//divis�o
	printf("A divis�o de %d e %d = %d \n", a, b, a / b);

	//Resto da divis�o
	printf("O resto da divis�o entre %d e %d = %d \n", a, b, a % b);

	//Valor absoluto
	printf("O valor absoluto de -3 = %d", abs(-3));
}

int a10_tiposDeVariaveis_2() {

	//manipulando int
	int a = 50;
	printf("O valor de a � %d \n", a);
	scanf("%d", &a);
	printf("O valor de a mudou para %d \n\n", a);

	//manupulando float
	float b = 5.5;
	printf("O valor de b � %f \n", b);
	scanf("%f", &b);
	printf("O valor de f mudou para %f \n\n", b);

	//manipulando char
	char letra = 't';
	printf("O valor de c � %c \n", letra);
	fflush(stdin); //faz a limpeza do buffer/lixo
	scanf(" %c", &letra);
	printf("O valor de c mudou para %c \n\n", letra);
}

int a10_tiposDeVariaveis_1()
{
	//imprime valor na tela
	printf("Ol� Mundo!!!");

	printf("\n\n");

	int a = 0;
	int b = 0;

	printf("Digite o valor de 'a': ");
	scanf_s("%d", &a);

	printf("Digite o valor de 'b': ");
	scanf_s("%d", &b);

	printf("O valor de 'a' + 'b' � %d", a + b);
}