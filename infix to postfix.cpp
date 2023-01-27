#include <iostream>
using namespace std;

class node {
public:
	node* next;
	char data;
};

node* top = NULL;
node* top_temp = NULL;
node* final = NULL;

node* create_node() {
	node* newnode = new node;
	return newnode;
}

void push_temp(char s) {
	node* newnode = create_node();
	newnode->data = s;
	if (top_temp == NULL) {
		top_temp = newnode;
		top_temp->next = NULL;
	}
	else {
		newnode->next = top_temp;
		top_temp = newnode;
	}
}

void push_final(char s) {
	node* newnode = create_node();
	newnode->data = s;
	if (top == NULL) {
		top = newnode;
		top->next = NULL;
	}
	else {
		newnode->next = top;
		top = newnode;
	}
}

void push_s(char s) {
	node* newnode = create_node();
	newnode->data = s;
	if (final == NULL) {
		final = newnode;
		final->next = NULL;
	}
	else {
		newnode->next = final;
		final = newnode;
	}
}

void pop_temp() {
	node* temp = top_temp;
	if (temp == NULL) {
	}
	else {
		top_temp = top_temp->next;
		delete(temp);
	}
}


void check(char str[]) {
	int i = 0;
	while (str[i] != '\0') {
		if (str[i] == '(') {
			push_temp(str[i]);
		}
		else if (str[i] == ')') {
			push_final(top_temp->data);
			pop_temp(); pop_temp();
		}
		else if (str[i] == '+' || str[i] == '-') {
			if (top_temp == NULL) {
				push_temp(str[i]);
			}
			else if (top_temp->data == '(') {
				push_temp(str[i]);
			}
			else if (top_temp->data == '+' || top_temp->data == '-') {
				push_final(top_temp->data);
				pop_temp();
				push_temp(str[i]);
			}
			else if (top_temp->data == '*' || top_temp->data == '/') {
				push_final(top_temp->data);
				pop_temp();
				push_temp(str[i]);
			}
		}
		else if (str[i] == '*' || str[i] == '/') {
			if (top_temp == NULL) {
				push_temp(str[i]);
			}
			else if (top_temp->data == '(') {
				push_temp(str[i]);
			}
			else if (top_temp->data == '*' || top_temp->data == '/') {
				push_final(top_temp->data);
				pop_temp();
				push_temp(str[i]);
			}
			else if (top_temp->data == '+' || top_temp->data == '-') {
				push_final(str[i]);
			}
		}
		else {
			push_final(str[i]);
		}
		i++;
	}
}

int main() {
	char str[20];
	cout << "INFIX TO POSTFIX CONVERTER" << endl;
	cout << "ENTER THE EQUATION : "; cin >> str;
	check(str);
	char final_ch = top_temp->data;
	push_final(final_ch);
	node* temp = top;
	cout << endl;
	while (temp != NULL) {
		push_s(temp->data);
		temp = temp->next;
	}

	node* final_out = final;
	while (final_out != NULL) {
		cout << final_out->data;
		final_out = final_out->next;
	}
}