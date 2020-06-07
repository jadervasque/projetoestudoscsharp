#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <stdbool.h>
#include <time.h>
#include <math.h>

void main() {

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
}

//a37
int aula() {

	char palavra[255];
	printf("Digite uma palavra: ");
	setbuf(stdin, 0);
	fgets(palavra, 255, stdin);
	palavra[strlen(palavra)-1] = '\0';
	printf("%s", palavra);
}

#define TAM 10
int a37_Constantes() {

	printf("%d", TAM);
	int i;
	for (i = 0; i < TAM; i++) {

	}
}

int a37_MenusSelecoesSimples() {

	int opcao;

	do {
		printf("Escolha uma opção: \n");
		printf("1. Opção A  |  2. Opção B  |  3. Opção C : ");
		scanf("%d", &opcao);
		printf("\n");

	} while (opcao < 1 && opcao > 3);

	switch (opcao) {
	case 1:
		printf("A Opção 1 foi escolhida.\n");
		break;
	case 2:
		printf("A Opção 2 foi escolhida.\n");
		break;
	case 3:
		printf("A Opção 3 foi escolhida.\n");
		break;
	}

}

int a35_For() {

	// incrementando dentro do for
	int i;
	for (i = 1; i <= 10; i++) {
		printf("i = %d\n", i);
	}

	// incrementando dentro do bloco
	int j;
	for (j = 1; j <= 10;) {
		printf("i = %d\n", j++);
	}
}

int a34_DoWhile() {
	int a = 1;
	do {
		printf("a = %d\n", a++);
	} while (a <= 10);
}

int a33_While() {

	int a = 1;

	while (a <= 9) {
		printf("a = %d\n", a++);
	}

	while (a > 0) {
		printf("a = %d\n", a--);
	}
}

int a32_GerarNumerosAleatorios() {

	// #include <time.h>

	// responsável por alimentar o rand de forma diferente
	srand((unsigned)time(NULL));

	for (int i = 0; i < 10; i++) {
		for (size_t i = 3; i < 10; i++) {
			// variável que recebe resto da divisão por 3 (aleatorio entre i e 9)
			int aleatorio = rand() % i;
			printf("%d, ", aleatorio);
		}
		printf("\n");
	}
}

int a30_ExercicioFixacao() {

	// ler 2 valores
	// apresentar as 4 operações básicas de matemática
	// apresentar o resultado da operação escolhida

	float a, b, resultado;
	printf("Digite valores para a e b: ");
	scanf("%f %f", &a, &b);
	printf("\n\n");

	printf("Digite a operação desejada:\n\n");
	printf("1.Somar | 2.Subtrair | 3.Dividir | 4.Multiplicar: ");
	int operacao;
	scanf("%d", &operacao);
	printf("\n\n");

	switch (operacao) {
	case 1:
		resultado = a + b;
		break;
	case 2:
		resultado = a - b;
		break;
	case 3:
		resultado = a / b;
		break;
	case 4:
		resultado = a * b;
		break;
	default:
		resultado = 0;
		break;
	}

	if (operacao >= 1 && operacao <= 4)
		printf("O resultado da operação escolhida é %.2f.\n\n", resultado);
	else
		printf("Não foi selecionado uma das operações informadas.");
}

int a24_ExercicioFixacao() {

	// leia três notas e calcule a média entre elas.
	// se o valor for maior que ou igual a 7 informe que o aluno foi aprovado,
	// senão informe que foi reprovado

	float nota1, nota2, nota3, media;

	printf("Digite as três notas no aluno separadas por espaço: ");
	scanf("%f %f %f", &nota1, &nota2, &nota3);
	media = (nota1 + nota2 + nota3) / 3;

	printf("\n\n");
	printf("A média do aluno é %.2f.", media);

	printf("\n\n");
	if (media >= 7) {
		printf("O aluno foi aprovado.\n\n");
	} else {
		printf("O aluno foi reprovado.\n\n");
	}
}

int a23_CondicionaisComChar() {

	char letra = 'x';
	if (letra == 'x') {
		printf("A letra é %c.\n\n", letra);
	}

	// ao invés de colocar %c, colocar %d, forçar inteiro
	printf("Código da letra = %d.\n\n", letra);
	if (letra == 120) {
		printf("A letra é x");
	}

}

int a22_CondicionaisBoleanas() {

	// inserir #include <stdbool.h>

	bool a = true, b = false;

	if (a) {
		printf("a é verdadeiro.\n\n");
	}

	if (!b) {
		printf("b é falso.\n\n");
	} else {
		printf("b é verdadeiro.\n\n");
	}
}

int a21_CondicionaisMatematicas() {

	int a = 5, b = 10, c = 15;

	if (a > 2) {
		printf("%d é maior do que 2.\n\n", a);
	}

	if (c >= b) {
		printf("%d é maior ou igual a b.\n\n", b);
	}

	if (a < 10) {
		printf("%d é menor que 10.\n\n", a);
	}

	if (a <= 10) {
		printf("%d é menor que ou igual a 10.\n\n", a);
	}

	if (c != 10) {
		printf("%d é diferente de 10.\n\n", c);
	}
}

int a20_CondicionaisSimples() {

	int a;
	float b = 2.5;
	char c = 'j';
	int opcao = 0;

	printf("Digite um valor inteiro para a variável a: ");
	scanf("%d", &a);
	printf("\n\n");

	if (a == 5) {
		printf("A variável a = %d.\n", a);
	}

	if (a % 2 == 0) {
		printf("A variável a é par.\n\n");
	} else {
		printf("A variável a é impar.\n\n");
	}

	do {
		printf("A variável opcao = %d.\n\n", opcao);
		printf("Digite um novo valor para a variável opcao: ");
		scanf("%d", &opcao);
	} while (opcao == 0 || opcao == 1);

}

int a18_ExercicioFixacao() {

	// Leia um algoritmo que leia 3 números inteiros de uma só vez e 
	// coloque o resultado da multiplicação entre os 3 em uma váriavel prória,
	// depois exibir essa variável

	int a, b, c, resultado;
	printf("Digite três números inteiros separados por espaço: ");
	scanf("%d %d %d", &a, &b, &c);
	printf("\n\n");
	resultado = a * b * c;
	printf("O resultado da multiplicação de %d, %d e %d = %d.", a, b, c, resultado);

}

int a16_ExercicioFixacao() {

	// Leia 2 notas e mostre o valor absoluto da diferença entre elas

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

	//Leia duas notas e apresente a média

	float a, b;
	printf("Digite o valor da média 'a': ");
	scanf("%f", &a);

	printf("\n\n");
	printf("Digite o valor da média 'b': ");
	scanf("%f", &b);

	printf("\n\n");
	printf("O valor da média de %f e %f = %f.", a, b, (a + b) / 2);

}

int a11_OperacoesMatematicas() {

	int a = 5, b = 3;

	//soma
	printf("A soma de %d e %d = %d \n", a, b, a + b);

	//subtração
	printf("A subtração de %d e %d = %d \n", a, b, a - b);

	//multiplicação
	printf("A multiplicação de %d e %d = %d \n", a, b, a * b);

	//divisão
	printf("A divisão de %d e %d = %d \n", a, b, a / b);

	//Resto da divisão
	printf("O resto da divisão entre %d e %d = %d \n", a, b, a % b);

	//Valor absoluto
	printf("O valor absoluto de -3 = %d", abs(-3));
}

int a10_tiposDeVariaveis_2() {

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

int a10_tiposDeVariaveis_1() {
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

int uri() {

	int a = 1;
}

int _1038() {

	typedef struct {
		char* Name;
		double Price;
	} Item;

	Item cardapio[5] = {
		{ "Cachorro Quente", 4.0 },
		{ "X-Salada", 4.5 },
		{ "X-Bacon", 5 },
		{ "Torrada simples", 2 },
		{ "Refrigerante", 1.5 }
	};

	int codigo, qtd;
	double total;
	scanf("%d %d", &codigo, &qtd);
	total = cardapio[codigo - 1].Price * qtd;
	printf("Total: R$ %.2lf\n", total);
}

int _1036() {

	double a, b, c, delta, r1, r2;
	scanf("%lf %lf %lf", &a, &b, &c);
	delta = (b * b) - 4 * a * c;
	if (a == 0 || delta < 0) {
		printf("Impossivel calcular\n");
	} else {
		r1 = (-b + sqrt(delta)) / (2 * a);
		r2 = (-b - sqrt(delta)) / (2 * a);
		printf("R1 = %.5lf\n", r1);
		printf("R2 = %.5lf\n", r2);
	}
}

int _1035() {

	int a, b, c, d;
	scanf("%d %d %d %d", &a, &b, &c, &d);
	if (b > c && d > a && (c + d) > (a + b) && c >= 0 && d >= 0 && a % 2 == 0)
		printf("Valores aceitos\n");
	else
		printf("Valores nao aceitos\n");
}

int _1014() {

	double xDistancia, yTotalCombustivelGasto, kml;
	scanf("%lf %lf", &xDistancia, &yTotalCombustivelGasto);
	kml = xDistancia / yTotalCombustivelGasto;
	printf("%.3lf km/l\n", kml);
}

int _1013() {

	int a, b, c, m1, m2;
	scanf("%d %d %d", &a, &b, &c);
	m1 = (a + b + abs(a - b)) / 2;
	m2 = (m1 + c + abs(m1 - c)) / 2;
	printf("%d eh o maior\n", m2);

}

int _1012() {

	double a, b, c, area;
	scanf("%lf %lf %lf", &a, &b, &c);

	//TRIANGULO RETÂNGULO, A = BASE, C = ALTURA
	area = a * c / 2;
	printf("TRIANGULO: %.3lf\n", area);

	//CIRCULO, RAIO = C, PI = 3.14159
	area = 3.14159 * c * c;
	printf("CIRCULO: %.3lf\n", area);

	//TRAPÉZIO, A = B = BASE, C = ALTURA
	area = (a + b) / 2 * c;
	printf("TRAPEZIO: %.3lf\n", area);

	//QUADRADO, LADO = B
	area = b * b;
	printf("QUADRADO: %.3lf\n", area);

	//RETÂNGULO, LADOS = A, B
	area = a * b;
	printf("RETANGULO: %.3lf\n", area);
}

int _1011() {

	double pi = 3.14159, raio, volume;
	scanf("%lf", &raio);
	volume = 4.0 / 3 * pi * raio * raio * raio;
	printf("VOLUME = %.3lf\n", volume);
}

int _1010() {

	struct Peca {
		int Codigo;
		double Quantidade;
		double ValorUnitario;
	} pecaA, pecaB;

	scanf("%d %lf %lf", &pecaA.Codigo, &pecaA.Quantidade, &pecaA.ValorUnitario);
	scanf("%d %lf %lf", &pecaB.Codigo, &pecaB.Quantidade, &pecaB.ValorUnitario);

	double total = 0;
	struct Peca pecas[2] = { pecaA, pecaB };
	int i;
	for (i = 0; i < 2; i++)
		total += pecas[i].Quantidade * pecas[i].ValorUnitario;
	printf("VALOR A PAGAR: R$ %.2lf\n", total);
}

int _1009() {

	char nome[100];
	double salary, amountSales, totalSalary, comission = 0.15;
	scanf("%s %lf %lf", nome, &salary, &amountSales);
	totalSalary = salary + (amountSales * comission);
	printf("TOTAL = R$ %.2lf\n", totalSalary);
}

int _1008() {

	int id, qth;
	float vph, salary;
	scanf("%d %d %f", &id, &qth, &vph);
	salary = qth * vph;
	printf("NUMBER = %d\n", id);
	printf("SALARY = U$ %.2f\n", salary);
}

int _1007() {

	int a, b, c, d, diferenca;
	scanf("%d %d %d %d", &a, &b, &c, &d);
	diferenca = a * b - c * d;
	printf("DIFERENCA = %d\n", diferenca);
}

int _1006() {

	float a, b, c, mediaPonderada, pa = 2.0f, pb = 3.0f, pc = 5.0f;
	scanf("%f %f %f", &a, &b, &c);
	mediaPonderada = (a * pa + b * pb + c * pc) / (pa + pb + pc);
	printf("MEDIA = %.1f\n", mediaPonderada);
}

int _1005() {

	float a, b, mediaPonderada, pa = 3.5f, pb = 7.5f;
	scanf("%f %f", &a, &b);
	mediaPonderada = (a * pa + b * pb) / (pa + pb);
	printf("MEDIA = %.5f\n", mediaPonderada);
}

int _1004() {

	int a, b, prod;
	scanf("%d %d", &a, &b);
	prod = a * b;
	printf("PROD = %d\n", prod);
}

int _1003() {

	int A, B, SOMA;
	scanf("%d %d", &A, &B);
	SOMA = A + B;
	printf("SOMA = %d\n", SOMA);
}

int _1002() {

	double n = 3.14159;
	double raio;
	scanf("%lf", &raio);
	double resultado = n * raio * raio;
	printf("A=%.4lf\n", resultado);
}

int _1001() {

	int a = 0;
	int b = 0;
	scanf("%d", &a);
	scanf("%d", &b);
	printf("X = %d\n", a + b);
}