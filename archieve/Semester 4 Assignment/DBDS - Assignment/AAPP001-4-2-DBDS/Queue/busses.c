#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <time.h>
#include <stdbool.h>

#include "busses.h"

const char * bustype[2] = {
	"Double Decker",
	"Coaches"
};

char * random_plate();

/* allocate a bus structure */
busptr new_bus(){
	busptr b = malloc(sizeof(bus));
	if (b) *b = (bus){ random_plate(), bustype[1], 42, NULL };
	return b;
}

/* free a bus structure which allocated by malloc */
void free_bus(busptr b){
	free(b->num);
	free(b);
}

/* Generate random car plate, lazy to think already */
char * random_plate(){
	srand(time(NULL));
	char * plate = malloc(8);
	memset(plate, 0, 8);
	do {
		int r = rand() % 3, i;
		for (i = 0; i <= r; i++)
			plate[strlen(plate)] = 'A' + (rand() % 26);
		sprintf(plate, "%s%d", plate, rand() % 10000);
	} while (search_bus(plate));
	return plate;
}

/* Search a specific bus by car plate and return its position */
unsigned int search_bus(char * num){
	int count = 1, result = 0;
	busptr b = busses.first;
	while (b){
		if (strcmp(num, b->num) == 0){
			result = count;
			break;
		}
		b = b->next;
		count++;
	}
	return result;
}

/*
	match 1 to 3 alphabet and 1 to 4 numbers after it
*/
bool bus_validate(char * num){
	char buffer[5];
	return sscanf(num, "%3[A-Z]%4[0-9]%c", buffer, buffer, buffer) == 2;
}
