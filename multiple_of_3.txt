#include <iostream>
using namespace std;

class node {
public:
	int data;
	node* next;
};

node* top1 = NULL;
node* top2 = NULL;
node* final = NULL;

class list : public node {
public:
	node* create_node() {
		node* newnode = new node;
		return newnode;
	}

	bool is_empty_1() {
		if (top1 == NULL) {
			return 1;
		}
		else {
			return 0;
		}
	}

	bool is_empty_2() {
		if (top2 == NULL) {
			return 1;
		}
		else {
			return 0;
		}
	}

	int pop_1() {
		node* temp = top1;
		int character1 = temp->data;

		top1 = top1->next;
		return character1;

		delete(temp);
	}

	node* top_1() {
		if (is_empty_1()) {
		}
		else {
			return top1;
		}
	}

	node* top_2() {
		if (is_empty_2()) {
		}
		else {
			return top2;
		}
	}

	void push_1(int s) {
		node* newnode = create_node();
		newnode->data = s;
		if (is_empty_1()) {
			top1 = newnode;
			top1->next = NULL;
		}
		else {
			newnode->next = top1;
			top1 = newnode;
		}
	}

	void push_2(int s) {
		node* newnode = create_node();
		newnode->data = s;
		if (is_empty_2()) {
			top2 = newnode;
			top2->next = NULL;
		}
		else {
			newnode->next = top2;
			top2 = newnode;
		}
	}

	bool is_empty_final() {
		if (final == NULL) {
			return 1;
		}
		else {
			return 0;
		}
	}

	void push_final() {
		if (is_empty_2()) {
			cout << "**ERROR**" << endl;
		}
		else {
			node* temp = top_2();
			while (temp != NULL) {
				node* newnode = create_node();
				newnode->data = temp->data;
				if (final == NULL) {
					final = newnode;
					final->next = NULL;
				}
				else if (final != NULL) {
					newnode->next = final;
					final = newnode;
				}
				temp = temp->next;
			}
		}
	}


	void check_div() {
		if (is_empty_1()) {
			cout << "THE LIST 1 IS EMPTY" << endl;
		}
		else {
			node* temp1 = top_1();
			while (temp1 != NULL) {
				if (temp1->data % 3 == 0) {
				}
				else {
					push_2(temp1->data);
				}
				temp1 = temp1->next;
			}
		}
	}

	void display_1() {
		if (top1 == NULL) {
			cout << "THE LIST 1 IS EMPTY" << endl;
		}
		else {
			node* temp1 = top_1();
			while (temp1 != NULL) {
				cout << temp1->data << endl;
				temp1 = temp1->next;
			}
		}
	}

	void display_2() {
		if (top2 == NULL) {
			cout << "THE LIST 2 IS EMPTY" << endl;
		}
		else {
			node* temp2 = top_2();
			while (temp2 != NULL) {
				cout << temp2->data << endl;
				temp2 = temp2->next;
			}
		}
	}

	void display_final() {
		if (is_empty_final()) {
			cout << "THE LIST 2 IS EMPTY" << endl;
		}
		else {
			node* temp3 = final;
			while (temp3 != NULL) {
				cout << temp3->data << endl;
				temp3 = temp3->next;
			}
		}
	}

};

int main() {
	list l1;
	l1.push_1(1);
	l1.push_1(2);
	l1.push_1(3);
	l1.push_1(4);
	l1.push_1(5);
	l1.push_1(6);
	l1.push_1(7);
	l1.push_1(8);
	l1.push_1(9);
	l1.push_1(10);
	l1.push_1(11);
	l1.push_1(12);
	l1.push_1(13);
	l1.push_1(14);
	l1.push_1(15);
	cout << "LIST 1" << endl;
	l1.display_1();
	cout << "LIST 2" << endl;
	l1.check_div();
	l1.push_final();
	l1.display_final();
}