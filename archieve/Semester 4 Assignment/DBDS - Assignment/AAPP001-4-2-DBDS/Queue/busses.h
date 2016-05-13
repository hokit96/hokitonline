#ifndef BUSSES
#define BUSSES

typedef struct bus bus, *busptr;

struct bus{
	char * num, *type;
	size_t capacity;
	busptr next;
};

struct busses{
	busptr first, last;
}busses;

const char * bustype[];

busptr new_bus();
void free_bus(busptr);
unsigned int search_bus(char *);
bool bus_validate(char * num);

#endif