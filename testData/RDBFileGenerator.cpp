#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif

#include <stdio.h>
#include <tchar.h> -- nahradit wchar.h
#include <string.h>
#include <stdlib.h>
#include <time.h>
#include <math.h>

typedef struct gates {
	char brana_id[5];
	char brana_typ[9];
	char verze_os[5];
} GATES;

typedef struct company {
	char nazev[10];
	char ico[5];
	char adresa[30];
} COMPANY;


typedef struct cars {
	char spz[8];
	char typ_vozidla[10];
	char hmotnost[5];
	char emisni_trida[2];
	char km_sazba[4];
	COMPANY* comp;
} CARS;


int random(int , int );
char* getfield(char* line, int num);

int main(int argc, char* argv[]) {
	if (argc <= 1) {
		printf("Not enough parameters...please provide number of records to be generated.");
		return 1;
	}
	int no_gatetypes = 3;
	char* gatetypes[3] = { "virtualni", "staticka", "mobilni" };

	int no_gates = 5;
	GATES* gates = (GATES*)malloc(no_gates * sizeof(GATES));
	strcpy(gates[0].brana_id, "0000");
	strcpy(gates[0].verze_os, "1.0");
	strcpy(gates[0].brana_typ, gatetypes[0]);

	strcpy(gates[1].brana_id, "1111");
	strcpy(gates[1].verze_os, "2.0");
	strcpy(gates[1].brana_typ, gatetypes[1]);

	strcpy(gates[2].brana_id, "2222");
	strcpy(gates[2].verze_os, "1.1");
	strcpy(gates[2].brana_typ, gatetypes[2]);

	strcpy(gates[3].brana_id, "3333");
	strcpy(gates[3].verze_os, "1.2");
	strcpy(gates[3].brana_typ, gatetypes[1]);

	strcpy(gates[4].brana_id, "4444");
	strcpy(gates[4].verze_os, "1.0");
	strcpy(gates[4].brana_typ, gatetypes[1]);

	int no_comp = 4;
	COMPANY* comps = (COMPANY*)malloc(no_comp * sizeof(COMPANY));
	strcpy(comps[0].ico, "ICO1");
	strcpy(comps[0].nazev, "company 1");
	strcpy(comps[0].adresa, "company address 1");
	strcpy(comps[1].ico, "ICO2");
	strcpy(comps[1].nazev, "company 2");
	strcpy(comps[1].adresa, "company address 2");
	strcpy(comps[2].ico, "ICO3");
	strcpy(comps[2].nazev, "company 3");
	strcpy(comps[2].adresa, "company address 3");
	strcpy(comps[3].ico, "ICO4");
	strcpy(comps[3].nazev, "company 4");
	strcpy(comps[3].adresa, "company address 4");


	int no_cars = 5;
	CARS* cars = (CARS*)malloc(no_cars * sizeof(CARS));
	cars[0].comp = &comps[0];
	strcpy(cars[0].emisni_trida, "A");
	strcpy(cars[0].km_sazba, "10");
	strcpy(cars[0].hmotnost, "7.5");
	strcpy(cars[0].typ_vozidla, "AA");
	strcpy(cars[0].spz, "AAA4567");

	cars[1].comp = &comps[0];
	strcpy(cars[1].emisni_trida, "A");
	strcpy(cars[1].km_sazba, "10");
	strcpy(cars[1].hmotnost, "17.5");
	strcpy(cars[1].typ_vozidla, "BB");
	strcpy(cars[1].spz, "BBB4567");

	cars[2].comp = &comps[1];
	strcpy(cars[2].emisni_trida, "C");
	strcpy(cars[2].km_sazba, "50");
	strcpy(cars[2].hmotnost, "12");
	strcpy(cars[2].typ_vozidla, "CC");
	strcpy(cars[2].spz, "QQQ4567");

	cars[3].comp = &comps[2];
	strcpy(cars[3].emisni_trida, "B");
	strcpy(cars[3].km_sazba, "20");
	strcpy(cars[3].hmotnost, "12");
	strcpy(cars[3].typ_vozidla, "CC");
	strcpy(cars[3].spz, "CCC4567");

	cars[4].comp = &comps[3];
	strcpy(cars[4].emisni_trida, "B");
	strcpy(cars[4].km_sazba, "20");
	strcpy(cars[4].hmotnost, "24");
	strcpy(cars[4].typ_vozidla, "DD");
	strcpy(cars[4].spz, "DDD4567");


	time_t t;
	srand((unsigned)time(&t));



	char* filename = (char*)malloc(400 * sizeof(char));
	strcpy(filename, "data-export.json");

	FILE* f_json = fopen(filename, "w");

	if (f_json == NULL) {
		printf("Error while creating output file!\n");
		exit(1);
	}
	long no_of_line_to_generated = atoi(argv[1]);
	int gate_no;
	int car_no;
	for (int i = 0; i < no_of_line_to_generated; i++) {
		gate_no = random(0, no_gates-1);
		car_no = random(0, no_cars - 1);
		fprintf(f_json, "%s", "{\n");
		fprintf(f_json, "\t\"brana_id\":\"%s\",\n", gates[gate_no].brana_id);
		fprintf(f_json, "\t\"typ_brany\":\"%s\",\n", gates[gate_no].brana_typ);
		fprintf(f_json, "\t\"prujezd\":{\n");

		fprintf(f_json, "\t\t\t\"datum_prujezdu\":\"%lu\",\n", (unsigned long)time(NULL));
		fprintf(f_json, "\t\t\t\"registrace_vozidla\":{\n");
		fprintf(f_json, "\t\t\t\t\"vozidlo\":{\"spz\":\"%s\",\n\t\t\t\t\"typ_vozidla\":\"%s\",\n\t\t\t\t\"hmotnost\":\"%s\",\n\t\t\t\t\"emisni_trida\":\"%s\",\n\t\t\t\t\"km_sazba\":\"%s\"\n\t\t\t},\n",
			cars[car_no].spz, cars[car_no].typ_vozidla, cars[car_no].hmotnost,
			cars[car_no].emisni_trida, cars[car_no].km_sazba);
		fprintf(f_json, "\t\t\t\"firma\":{\n\t\t\t\t\"nazev\":\"%s\",\n\t\t\t\t\"ico\":\"%s\",\n\t\t\t\t\"adresa\":\"%s\"\n\t\t\t},\n",
			cars[car_no].comp->nazev, cars[car_no].comp->ico, cars[car_no].comp->adresa);
		fprintf(f_json, "\t\t\t\"ujete_km\":\"%d\"\n",random(1, 100));
		fprintf(f_json, "\t\t}\n");
		fprintf(f_json, "\t},\n");
		fprintf(f_json, "\t\"systemova_data\":{\n");
		fprintf(f_json, "\t\t\"brana_id\":\"%s\",\n", gates[gate_no].brana_id);
		fprintf(f_json, "\t\t\"verze_os\":\"%s\",\n", gates[gate_no].verze_os);
		fprintf(f_json, "\t\t\"systemovy_datum_cas\":\"%lu\",\n", (unsigned long)time(NULL));

		if (strcmp(gates[gate_no].brana_typ, gatetypes[0]) == 0) {
			fprintf(f_json, "\t\t\"GPS\":\"%d %d\",\n", random(100, 1000), random (100, 1000));
			fprintf(f_json, "\t\t\"presnost\":\"%d\"\n", random(0, 6));
		}
		if (strcmp(gates[gate_no].brana_typ, gatetypes[1]) == 0) {
			fprintf(f_json, "\t\t\"napeti\":\"%f\",\n", ((float)random(110, 130))/10);
			fprintf(f_json, "\t\t\"proud\":\"%f\"\n", ((float)random(100, 110)) / 10);
		}
		if (strcmp(gates[gate_no].brana_typ, gatetypes[2]) == 0) {
			fprintf(f_json, "\t\t\"misto\":\"%s %d %s\",\n", "Ulice ", random(10,100), "Misto");
			fprintf(f_json, "\t\t\"pozice\":\"%d %d\",\n", random(100, 1000), random(100, 1000));
			fprintf(f_json, "\t\t\"baterie_typ\":\"%d\",\n", random(0, 10));
			fprintf(f_json, "\t\t\"pocet_cyklu\":\"%d\"\n", random(0, 100));
		}
		fprintf(f_json, "\t}\n");
		fprintf(f_json, "}\n");
	}
	fclose(f_json);
	return 0;
}

char* getfield(char* line, int num) {
	char *tok;
	for (tok = strtok(line, ",");
		tok && *tok;
		tok = strtok(NULL, ",\n"))
	{
		if (!--num)
			return tok;
	}
	return NULL;
}

int random(int min, int max){
	return (rand() % (max + 1 - min)) + min;
}
