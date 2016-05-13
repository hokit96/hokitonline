#include <stdio.h>
#include <ctype.h>
#include <string.h>
#include <stdbool.h>

#include "functions.h"
#include "busses.h"

void scene_menu();
void scene_arrive();
void scene_list();
void scene_search();

int number;
char * buffer;
busptr temp;
void(*scene)() = &scene_menu;

/*
	Use functions pointers to control each scene
	to avoid call stack level too deep (stack overflow).
	The program stop when no scene (scene = NULL).
*/
int main(){
	busses.first = busses.last = NULL;
	set_title(Bus Stop);
	while (scene){
		clear();
		scene();
	}
	msg("Good Bye!");
}

void scene_menu(){
	printf("\n\tTBS - Terminal Bojio Sentiasa\n");
	printf("\n\t1. Register arrived bus\n");
	printf("\t2. Bus leave\n");
	printf("\t3. View Queue\n");
	printf("\t4. Search Bus\n");
	printf("\t5. Exit\n");
	printf("\n\tChoice: ");
	if (!getint(&number)){
		msg("Invalid Action!");
		return;
	}
	switch (number){
	case 1:
		temp = new_bus();
		if(temp)scene = &scene_arrive;
		else msg("Sorry, error occurs when allocating memory,\n\tPlease try again later!")
		return;
	case 2:
		if (!busses.first){
			msg("Sorry, The Queue is Empty!");
			return;
		}
		printf("\n\tBus %s leaved the queue.\n\n\t", busses.first->num);
		busptr tempFirst = busses.first->next;
		if (busses.last == busses.first) busses.last = NULL;
		free_bus(busses.first);
		busses.first = tempFirst;
		pause();
		return;
	case 3:
		clear();
		scene_list();
		return;
	case 4:
		scene_search();
		return;
	case 5:
		scene = NULL;
		return;
	default:
		msg("Invalid Action!");
		return;
	}
}

void scene_arrive(){
	printf("\n\tRegister Arrived Bus\n");
	printf("\n\t1. Number  : %s\n", temp->num);
	printf("\t2. Type    : %s\n", temp->type);
	printf("\t3. Capacity: %u\n", temp->capacity);
	printf("\n\t4. Confirm\n");
	printf("\t5. Cancel\n");
	printf("\n\tChoice: ");
	if (!getint(&number)){
		msg("Invalid Action!");
		return;
	}
	switch (number){
	case 1:
		printf("\n\tNumber: ");
		buffer = getpstr();
		for (number = 0; number < strlen(buffer); number++)
			buffer[number] = toupper(buffer[number]);
		if (!bus_validate(buffer) || search_bus(buffer)){
			msg(bus_validate(buffer) ? "Bus already in queue!":"Invalid Number!");
			free(buffer);
			return;
		}
		temp->num = buffer;
		return;
	case 2:
		printf("\n\t1. %s\n", bustype[0]);
		printf("\t2. %s\n", bustype[1]);
		printf("\n\tWhich Type? ");
		fflush(stdout);
		if (!getint(&number)) msg("Invalid Type!")
		else if (number == 1 || number == 2) temp->type = bustype[number - 1];
		else msg("Invalid Type!")
		return;
	case 3:
		printf("\n\tCapacity: ");
		if (!getint(&number) && number < 0){
			msg("Invalid Input!");
			return;
		}
		temp->capacity = number;
		return;
	case 4:
		if (busses.last)busses.last->next = temp;
		if (!busses.first) busses.first = temp;
		busses.last = temp;
		scene = &scene_menu;
		return;
	case 5:
		free(temp);
		scene = &scene_menu;
		return;
	default:
		msg("Invalid Action!");
		return;
	}
}

void scene_list(){
	printf("\n\tBusses in Queue\n");
	temp = busses.first;
	number = 0;
	printf("\n\t %-7s | %-13s | %-8s", "Number", "Type", "Capacity");
	printf("\n\t---------|---------------|----------");
	while (temp)
	{
		printf("\n\t %-7s | %-13s | %8d", temp->num, temp->type, temp->capacity);
		number++;
		temp = temp->next;
	}
	printf("\n\t------------------------------------\n");
	printf("\tTotal Busses: %d\n\n\t", number);
	pause();
}

void scene_search(){
	printf("\n\tOkay, Google!\n");
	printf("\tSearch: ");
	buffer = getpstr();
	for (number = 0; number < strlen(buffer); number++)
		buffer[number] = toupper(buffer[number]);
	if (bus_validate(buffer) && (number = search_bus(buffer))){
		printf("\n\tThe bus %s is the %d%s bus in queue\n\t", buffer, number, getoi(number));
		pause();
	}
	else if (!number){
		msg("Error 404: Bus Not Found!");
	} else msg("Invalid Keyword!");
	free(buffer);
}