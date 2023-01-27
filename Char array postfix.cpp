#include <iostream>
using namespace std;



class point {
public:
    int x, y;
    point() {
        x = 3;
        y = 3;
    }

    ////
    point operator+(point& pnick) {
        point ptemp;
        ptemp.x = x + pnick.x;
        ptemp.y = y + pnick.y;
        return ptemp;
    }

    void operator=(point& pnick) {
        x = pnick.x;
        y = pnick.y;
    }
    ////

    bool operator==(point& pnick) {
        if (x == pnick.x && y == pnick.y) {
            return true;
        }
        else {
            return false;
        }
    }

    bool operator!=(point& pnick) {
        if (x != pnick.x && y != pnick.y) {
            return true;
        }
        else {
            return false;
        }
    }

    bool operator<=(point& pnick) {
        if (x <= pnick.x && y <= pnick.y) {
            return true;
        }
        else {
            return false;
        }
    }

    bool operator>=(point& pnick) {
        if (x >= pnick.x && y >= pnick.y) {
            return true;
        }
        else {
            return false;
        }
    }

    friend ostream& operator<<(ostream& output, point& pnick) {
        output << "X:" << pnick.x << endl;
        output << "Y:" << pnick.y << endl;
        return output;
    }

    friend istream& operator>>(istream& input, point& pnick) {
        cout << "X:";
        input >> pnick.x;
        cout << endl;
        cout << "Y:";
        input >> pnick.y;
        cout << endl;
        return input;
    }


};

int main() {
    point p1, p2, p3;

    p1.x = 1;
    p1.y = 2;
    //p3 = p1;

    p3 = p1 + p2;

    cout << p3.x;
}