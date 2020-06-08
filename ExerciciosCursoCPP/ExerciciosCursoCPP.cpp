#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <string>

void a63_ImprimeVetor(int* vetor, int tamanho);
void a63_PreencheVetor(int* vetor, int tamanho);

using namespace std;

void aula();

int main() {

    int qtdRepeticoes = 1;
    //printf("Digite a quantidade de repetições: ");
    //qtdRepeticoes = scanf("%d", &qtdRepeticoes);

    cout << "\n\n";
    for (int i = 0; i < qtdRepeticoes; i++) {
        //uri();
        setlocale(LC_ALL, "");
        aula();
        cout << "\n\n";
    }
    system("pause");

    return 0;
}

#pragma   region a54_AlocarVetor
int* a65_AlocarVetor(int tamanho) {
    
    int* aux;
    aux = (int*)malloc(tamanho * sizeof(int));
    return aux;
}

void aula() {

    int* vetor, tamanho;
    cout << "Digite o tamanho do vetor desejado: ";
    cin >> tamanho;
    cout << endl;

    vetor = a65_AlocarVetor(tamanho);
    a63_PreencheVetor(vetor, tamanho);
    a63_ImprimeVetor(vetor, tamanho);
}
#pragma endregion

#pragma region a64_IncluindoArquivosDeCabecalhos
//adiciona o arquivo de cabeçalho
#include "Funcoes.h"

void a64_IncluindoArquivosDeCabecalhos() {

    Imprimir((char*)"Ola mundo!!!");
}
#pragma endregion

#pragma region a63_Vetor

void a63_PreencheVetor(int* vetor, int tamanho) {
    int i;
    //percorrendo vetor e preenchendo posições
    for (i = 0; i < tamanho; i++) {
        cout << "Entre com o valor da posicao " << i << ": ";
        cin >> vetor[i];
    }
    //adiciona um espaço ao final da operação
    cout << endl;
}

void a63_ImprimeVetor(int* vetor, int tamanho) {
    int i;
    //percorrendo vetor e imprimindo dados
    for (i = 0; i < tamanho; i++) {
        cout << "vetor[" << i << "] = " << vetor[i] << endl;
    }
}

void a63_Vetor() {

    //definindo tamanho do vetor
    int t;
    cout << "Entre com o tamanho do vetor: ";
    cin >> t;

    cout << endl;

    //criando um vetor com tamanho t
    //utilizei o malloc porque t não é constante
    int* vetor = (int*)malloc(t * sizeof(int));

    //preenchendo vetor
    a63_PreencheVetor(vetor, t);

    //imprimindo vetor
    a63_ImprimeVetor(vetor, t);
}
#pragma endregion

#pragma region a62_FuncoesComPonteiros
void a62_aumentaDez(int* numero) {
    *numero = *numero + 10;
}

void a62_FuncoesComPonteiro() {

    int a = 10;
    cout << "a = " << a;
    cout << "\n";
    a62_aumentaDez(&a);
    cout << "a = " << a;
}
#pragma endregion

void a59_LimparTela() {

    int a;
    cout << "Digite o valor da variável a: ";
    cin >> a;
    system("CLS");
}

void a55_Ponteiro() {

    //declaração de variável;
    int b = 20;

    //declaração de ponteiro
    int* ponteiro = &b;

    //imprimindo b
    cout << "O valor da variável b é: " << b << "\n";

    //modificando b através do ponteiro
    *ponteiro = 40;

    //imprimindo b
    cout << "O valor da variável b é: " << b << "\n";
}

void a49_ExercicioFixaxao() {

    //construção da matriz1
    //define tamanho da matriz quadrada
    const int t = 3;
    int matriz1[t][t];

    //insere os valores digitados pelo usuário
    int i, j;
    for (i = 0; i < t; i++) {
        for (j = 0; j < t; j++) {
            cout << "Digite o valor para a posicao " << i << ", " << j << ": ";
            cin >> matriz1[i][j];
        }
    }

    //contrução da matriz2
    int matriz2[t][t];
    i = 0;
    j = 0;
    int k = t; //linha inicial da matriz1, o qual é decrescente

    //percorre a matriz2
    for (i = 0; i < t; i++) {
        --k;
        int l = 0; //coluna inicial da matriz1, o qual é crescente
        for (j = 0; j < t; j++) {
            //busca o valor da linha em ordem decrescente e da coluna em ordem crescente e seta em matriz1
            matriz2[i][j] = matriz1[k][l++];
        }
    }
    cout << "\n";
    //imprime os valores da matriz2
    i = 0;
    j = 0;
    for (i = 0; i < t; i++) {
        for (j = 0; j < t; j++) {
            int out = matriz2[i][j];
            if (out < 10) {
                cout << "  " << out;
            } else {
                cout << " " << out;
            }
        }
        cout << "\n";
    }
}

void a48_Matrizes() {

    cout << "MATRIZ 1\n\n";
    const int t = 10;
    int i, j;
    int matriz[t][t];
    for (i = 0; i < t; i++) {
        for (j = 0; j < t; j++) {
            matriz[i][j] = i + j;
        }
    }
    int k, l;
    for (k = 0; k < t; k++) {
        for (l = 0; l < t; l++) {
            int out = matriz[k][l];
            if (out < 10) {
                cout << "  " << out;
            } else {
                cout << " " << out;
            }
        }
        cout << "\n";
    }

    cout << "\n\n";

    cout << "MATRIZ 2\n\n";
    const int t2 = 2;
    int matriz2[t2][t2];
    int m, n;
    for (m = 0; m < t2; m++) {
        for (n = 0; n < t2; n++) {
            cout << "Digite o valor para a posição " << m << ", " << n << ": ";
            cin >> matriz2[m][n];
        }
    }
    int o, p;
    for (o = 0; o < t2; o++) {
        for (p = 0; p < t2; p++) {
            int out = matriz2[o][p];
            if (out < 10) {
                cout << "  " << out;
            } else {
                cout << " " << out;
            }
        }
        cout << "\n";
    }

}

void a47_CriarAcessarStrings() {

    string palavra;
    printf("Digite uma palavra: ");
    cin >> palavra;
    cout << palavra;
}