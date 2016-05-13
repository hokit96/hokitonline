#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <stdbool.h>

#include "functions.h"

/*
	get char 1 by 1 and allocate memory for
	the string to ensure no input buffer
	remained in the input buffer.
*/
char * getpstr(){
	char c, *str = malloc(1), *temp;
	unsigned int len = 0;
	str[0] = 0;
	while ((c = getchar()) != '\n'){
		temp = malloc(len + 2);
		memmove(temp, str, len + 1);
		free(str);
		str = temp;
		str[len] = c;
		str[len + 1] = 0;
		len++;
	}
	return str;
}

/* Get string and check is that a valid number */
bool getint(int * i){
	char * temp = getpstr(), c;
	bool result = (sscanf(temp, "%d%c", i, &c) == 1);
	free(temp);
	return result;
}

bool confirm(char * msg){
	printf("\n\t%s", msg);
	fflush(stdout);
	char* temp = getpstr();
	bool result = (temp[0] == 'Y' || temp[0] == 'y');
	free(temp);
	return result;
}