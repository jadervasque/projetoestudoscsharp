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
    //system("pause");

    return 0;
}

void aula() {}

#pragma region a71_EstruturasStruct
typedef struct Fruta {
    string Cor;
    string Nome;
};

void a71_EstruturasStruct() {

    Fruta* fruta = new Fruta;
    fruta->Cor = "Amarela";
    fruta->Nome = "Banana";
    char text[255];
    sprintf(text, "%s %s", fruta->Nome.c_str(), fruta->Cor.c_str());
    cout << text << endl;
}
#pragma endregion

#pragma region a70_StructEmStruct
typedef struct Data {
    int Dia;
    int Mes;
    int Ano;
};

typedef struct Aluno {
    int Id;
    Data Nascimento;
};

void a70_StructEmStruct() {

    Aluno a;
    a.Id = 15;
    a.Nascimento.Ano = 1996;
    a.Nascimento.Mes = 1;
    a.Nascimento.Dia = 17;
    char text[255];
    sprintf(text, "%02d/%02d/%04d", a.Nascimento.Dia, a.Nascimento.Mes, a.Nascimento.Ano);
    cout << text << endl;
}
#pragma endregion

#pragma region a69_Struct

struct  Word {
    int index;
    char letter;
    char text[255];
};

void a69_Struct() {

    struct Word pp;
    pp.index = 0;
    pp.letter = 'c';
    strcpy(pp.text, "Palavrinha");
    cout << "Ordem: " << pp.index << ", Primeira letra: " << pp.letter << ", Primeira palavra: " << pp.text;

    cout << endl;
    cout << endl;
    cout << "Lista de Struct";

    int t = 3;
    struct Word* lp = new Word[t];
    for (int i = 0; i < t; i++) {
        lp[i].index = i;
        lp[i].letter = (char)(i + 65);
        strcpy(lp[i].text, "Word " + i);
    }

    for (int i = 0; i < t; i++) {
        cout << "I: " << lp[i].index << ", L: " << lp[i].letter << ", T: " << lp[i].text << endl;
    }


}

#pragma endregion

void a68_AlocacaoMatrizesCPP() {

    int linhas, colunas;
    cout << "Digite o número de linhas: ";
    cin >> linhas;
    cout << "Digite o número de colunas: ";
    cin >> colunas;

    int** matriz;

    matriz = (int**) new int[linhas];
    for (int i = 0; i < linhas; i++) {
        matriz[i] = (int*) new int[colunas];
    }

    for (int i = 0; i < linhas; i++) {
        for (int j = 0; j < colunas; j++) {
            matriz[i][j] = j;
            cout << matriz[i][j];
        }
        cout << endl;
    }

    free(matriz);
}

void a67_AlocacaoMatrizes() {

    int linhas, colunas;
    cout << "Digite o número de linhas: ";
    cin >> linhas;
    cout << "Digite o número de colunas: ";
    cin >> colunas;

    int** matriz;

    matriz = (int**)malloc(linhas * sizeof(int*));
    for (int i = 0; i < linhas; i++) {
        matriz[i] = (int*)malloc(colunas * sizeof(int));
    }

    for (int i = 0; i < linhas; i++) {
        for (int j = 0; j < colunas; j++) {
            matriz[i][j] = j;
            cout << matriz[i][j];
        }
        cout << endl;
    }

    free(matriz);
}

#pragma region a66_AlocarVetor_CPP

#include <new>

void a66_AlocarVatorCPP() {

    int tamanho, i;

    cout << "Digite o tamanho: ";
    cin >> tamanho;

    //criar ponteiro que recebe novo vetor vazio
    int* vetor = new int[tamanho];

    //modificando e imprimindo valores
    for (i = 0; i < tamanho; i++) {
        vetor[i] = i;
        cout << vetor[i] << endl;
    }
}

#pragma endregion

#pragma   region a65_AlocarVetor
int* a65_AlocarVetor(int tamanho) {

    int* aux;
    aux = (int*)malloc(tamanho * sizeof(int));
    return aux;
}

void a65_AlocacaoDinamicaVetores() {

    int* vetor, tamanho;
    cout << "Digite o tamanho do vetor desejado: ";
    cin >> tamanho;
    cout << endl;

    vetor = a65_AlocarVetor(tamanho);
    a63_PreencheVetor(vetor, tamanho);
    a63_ImprimeVetor(vetor, tamanho);

    //limpar vetor da memória
    free(vetor);
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