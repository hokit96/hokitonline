//Part A: Linked List

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>

struct  customer{
	char cusName[100]; //customer name
	int cusNum; //customer number
	char cusGen[7]; //customer gender
	char orderDes[1000]; //order description
	char cusAdd[200]; //customer address
	struct customer * prev, *next; //pointer to the next node and previous node
};

struct customer *cusStart = NULL, *cusEnd = NULL; //add customer at beginning is empty and add customer at the end is empty

// function prorotypes
int main();
void menu();
void printCus(struct customer *);
struct customer * createCus();
void addCusStart();
void addCusEnd();
void printListStart();
void printListEnd();
void removeCus();

// varaibles
int option; //this is for switch case
char yesno; //for confirmation

void(*scene)(); // function pointer for control the scene.

int main(){
	system("title Linked List"); // change the title
	scene = &menu;
	while (scene){ // while there is a scene, if not then the program will terminated.
		system("cls"); // clear the screen
		scene(); // and run the scene
	}
}

void menu(){ //main menu
	printf("\n\n\n\n");
	printf("\t\t\t\tMenu\n");
	printf("\t_______________________________________________\n\n");
	printf("\t1. Add new customer to the beginning.\n");
	printf("\t2. Add new customer to the end.\n");
	printf("\t3. Print out entire list from the beginning.\n");
	printf("\t4. Print out entire list from the end.\n");
	printf("\t5. Remove a customer.\n");
	printf("\t6. Exit\n\n");
	printf("\tYour option: ");
	scanf_s("%d", &option); //read integer data from option
	switch (option){
	case 1: scene = &addCusStart; //when user choose 1, link to add customer at beginning
		break;
	case 2: scene = &addCusEnd; //when user choose 2, link to at customer at end 
		break;
	case 3: scene = &printListStart;//when user choose 3, link to print customer list from beginning
		break;
	case 4: scene = &printListEnd; //when user choose 4, link to print customer list from end
		break;
	case 5: scene = &removeCus; //when user choose 5, link to remove customer
		break;
	case 6:
		printf("\n\tYou will now exiting the system!\n");
		getch();
		scene = NULL; // when no scene is available, then the system will exit.
	default: //if non of above selected
		return; // return but without changing the scene so the current scene will run again.
	}
}

void printCus(struct customer * cus){
	printf("\n\tCustomer name: %s", cus->cusName);
	printf("\n\tCustomer number: No. %d", cus->cusNum);
	printf("\n\tCustomer gender: %s", cus->cusGen);
	printf("\n\tOrder description: %s", cus->orderDes);
	printf("\n\tCustomer address: %s", cus->cusAdd);
}

struct customer * createCus(){
	struct customer * newCus = malloc(sizeof(struct customer)); //data size in newCus is equal to size of "struct customer"
	*newCus = (struct customer){ 0 }; //item inside newCus set to empty.
	printf("\n\n\tEnter customer name: ");
	fflush(stdin); //clear standard input
	fgets(&newCus->cusName, 100, stdin); //retrieve data(included space) from structure of newCus that contain customer name, size 100, standard input
	if (newCus->cusName[strlen(newCus->cusName) - 1] == '\n')newCus->cusName[strlen(newCus->cusName) - 1] = 0;
	//if last character of string is newline (enter), remove the character (enter). 
	printf("\tEnter customer number: No. ");
	fflush(stdin); //flush that standard input
	scanf("%d", &newCus->cusNum);
	struct customer * temp = cusStart;
	while (temp){ // search the entire list to find duplicated number.
		if (temp->cusNum == newCus->cusNum){
			printf("\tThis number already existed! \n");
			getch();
			free(newCus);
			return NULL; // return NULL for reset the form.
		}
		temp = temp->next;
	}
	printf("\tEnter customer gender (M/F): ");
	fflush(stdin);
	scanf("%c", newCus->cusGen);
	if (tolower(newCus->cusGen[0]) != 'm' && tolower(newCus->cusGen[0]) != 'f'){ // use tolower to shorter the code
		printf("\tInvalid gender! \n");
		getch();
		free(newCus);
		return NULL;
	}
	if (tolower(newCus->cusGen[0]) == 'm'){
		strcpy(newCus->cusGen, "Male");
	}
	else{
		strcpy(newCus->cusGen, "Female");
	}
	printf("\tEnter order description: ");
	fflush(stdin);
	fgets(&newCus->orderDes, 1000, stdin); //must include the exact size of the array. 
	if (newCus->orderDes[strlen(newCus->orderDes) - 1] == '\n')newCus->orderDes[strlen(newCus->orderDes) - 1] = 0;
	printf("\tEnter customer address: ");
	fflush(stdin);
	fgets(&newCus->cusAdd, 200, stdin);
	if (newCus->cusAdd[strlen(newCus->cusAdd) - 1] == '\n')newCus->cusAdd[strlen(newCus->cusAdd) - 1] = 0;
	system("cls");
	printf("\n\tYou had entered");
	printCus(newCus);
	printf("\n\n\tConfirm? (Y/N)");
	return newCus;
}

void addCusStart(){
	struct customer * newCus = createCus();
	if (newCus == NULL) return; // return when reset form is required.
	scanf("%c", &yesno);
	if (tolower(yesno) == 'y'){
		if (cusStart) {
			cusStart->prev = newCus; //previous node of add customer at beginning is new customers
			newCus->next = cusStart; //new customer node next node is add customer at beginning
		}
		if (!cusEnd) cusEnd = newCus; //if not add customer at the end, add customer at the end is add new customer
		cusStart = newCus; //add customer at beginning is equal to add new customer 
		scene = &menu; //return to main menu
	}
	else{
		free(newCus); //free(remove) the current data
		return; //reset the form 
	}
}

void addCusEnd(){
	struct customer * newCus = createCus();
	scanf("%c", &yesno);
	if (tolower(yesno) == 'y'){
		if (cusEnd) {
			cusEnd->next = newCus; //add customer next node is add new customer
			newCus->prev = cusEnd;  //add new customer previous node is add customer at end
		}
		if (!cusStart) cusStart = newCus; //if not add customer at beginning, add customer at beginning is add new cus
		cusEnd = newCus; //add customer at the end is add new customer
		scene = &menu; //return to main menu
	}
	else{
		free(newCus); //free current data
		return; //reset the form
	}
}

void printListStart(){
	struct customer * current = cusStart; //declare one pointer as current, current = add customer at beginning.
	if (current == NULL){
		printf("\n\n\n\t\tThere are no record yet!");
	}
	while (current){
		printCus(current);
		printf("\n");
		current = current->next; //which allow system to keep print until there is no more customer to print (top to bottom)
	}
	getch();
	scene = &menu;
}

void printListEnd(){
	struct customer * current = cusEnd; //declare one pointer as current, current = add customer at the end.
	if (current == NULL){
		printf("\n\n\n\t\tThere are no record yet!");
	}
	while (current){
		printCus(current);
		printf("\n");
		current = current->prev; //which allow system to keep printing until there is no more customer to print (from buttom to top)
	}
	getch();
	scene = &menu;
}

void removeCus(){
	printf("\n\n\tList of customers:  \n");
	int count = 0;
	struct customer * current = cusStart;
	while (current){
		printf("\t%3d. %s\n", count + 1, current->cusName);
		current = current->next; //print out all customer name
		count++;
	}
	printf("\n\n\n\tWhich you want to remove?");
	printf("\n\tYour selection: ");
	scanf("%d", &count);
	fflush(stdin);
	current = cusStart;
	for (int i = 1; i < count; i++) current = current->next;// get the selected customer
	printCus(current);
	printf("\n\tAre u sure to remove this? (Y/N)");
	scanf("%c", &yesno);
	fflush(stdin);
	if (tolower(yesno) == 'y'){
		if (current->next) current->next->prev = current->prev;
		//if current point to next node, current node to next node and point back to current node is equal to current to previous node.
		if (current->prev) current->prev->next = current->next;
		//if current point to previous node, current node to previous node and point back to current node is equal to current to next node.
		if (cusStart == current) cusStart = current->next;
		//if add customer at beginning equal to current node, add customer to beginning is current node to next node.
		if (cusEnd == current) cusEnd = current->prev;
		//if add customer at end equal to current node, add customer at end is equal current to previous node. 
		free(current); //remove data
		scene = &menu; //back to main
	}
	else scene = &menu; //if user press no, data will be remain and back to main menu
}