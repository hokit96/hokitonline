#ifndef COMMON
#define COMMON

#pragma region Macros

#ifdef _WIN32 // Macro for Windows

#define set_title(title) {\
	char cmd[100];\
	sprintf(cmd, "title %s", #title);\
	system(cmd);}
#define clear() {system("cls");}
#define pause() {\
	printf("Press any key to continue . . .");\
	fflush(stdout);\
	system("pause >nul");}

#elif defined(__linux) // Macro for linux

#define set_title(title) {printf("%c%s%s%c", 0x1B, "]0;", #title, 7);}
#define clear() system("clear");
#define pause() {\
	printf("Press any key to continue . . .");\
	fflush(stdout);\
	system("read -s -n 1 key");}

#else
#error This code only compatible with Windows or Linux only.
#endif

#define msg(message) {\
	printf("\n\t%s\n\t", message);\
	pause(); }

#define getoi(num) ((num % 100 > 10 && num % 100 < 20) ? "th" : (num % 10 == 1) ? "st" : (num % 10 == 2) ? "nd" : (num % 10 == 3) ? "rd" : "th")

#pragma endregion

/* Have to manually free the address */
char * getpstr();
bool getint(int * i);
bool confirm(char * message);

#endif