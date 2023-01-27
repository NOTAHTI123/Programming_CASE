#include <iostream>
#include <math.h>
using namespace std;
 
struct point{
    float x1,y1,x2,y2,x1_mid,y1_mid,x2_mid,y2_mid;
    
};

void input(struct point* p_main){
    cout<<"ENTER X1 : ";cin>>p_main->x1;cout<<endl;
    cout<<"ENTER Y1 : ";cin>>p_main->y1;cout<<endl;
    cout<<"ENTER X2 : ";cin>>p_main->x2;cout<<endl;
    cout<<"ENTER Y2 : ";cin>>p_main->y2;cout<<endl;
}

float distance(struct point p_main){
    float distance_points;
    distance_points = sqrt(pow(p_main.x2-p_main.x1,2)+pow(p_main.y2-p_main.y1,2));
    return distance_points;
}

void is_zero(struct point* p_main){
    if(p_main->x1==0&&p_main->y1==0){
        cout<<"THE POINTS ("<<p_main->x1<<","<<p_main->y1<<") ARE AT ORIGIN"<<endl;
    }
    else{
        cout<<"THE POINTS ("<<p_main->x1<<","<<p_main->y1<<") ARE NOT AT ORIGIN"<<endl;
    }

    if(p_main->x2==0&&p_main->y2==0){
        cout<<"THE POINTS ("<<p_main->x2<<","<<p_main->y2<<") ARE AT ORIGIN"<<endl;
    }
    else{
        cout<<"THE POINTS ("<<p_main->x2<<","<<p_main->y2<<") ARE NOT AT ORIGIN"<<endl;
    }
}

point middle_point(struct point* p_main){
    p_main->x1_mid = p_main->x1/2;
    p_main->y1_mid = p_main->y1/2;
    p_main->x2_mid = p_main->x2/2;
    p_main->y2_mid = p_main->y2/2;
    return *p_main;
}

void is_equal_to(struct point p_first, struct point p_second){
    if(p_first.x1==p_second.x2&&p_first.y1==p_second.y2){
        cout<<"THE POINTS ARE EQUAL"<<endl<<endl;
    }
    else{
        cout<<"THE POINTS ARE NOT EQUAL"<<endl<<endl;
    }
}

void is_greater_than(struct point p_first, struct point p_second){
    if(p_first.x1>p_second.x2&&p_first.y1>p_second.y2){
        cout<<"THE POINTS ("<<p_first.x1<<","<<p_first.y1<<") IS GREATER THAN ("<<p_second.x2<<","<<p_second.y2<<")"<<endl<<endl;
    }
    else if(p_second.x2>p_first.x1&&p_second.y2>p_first.y1){
        cout<<"THE POINTS ("<<p_second.x2<<","<<p_second.y2<<") IS GREATER THAN ("<<p_first.x1<<","<<p_first.y1<<")"<<endl<<endl;
    }
    else{
        cout<<"THE POINTS EQUAL"<<endl<<endl;
    }
}
 
int main(){
    point p_main;
    input(&p_main);
    cout<<distance(p_main)<<endl;
    is_zero(&p_main);
    middle_point(&p_main);
    cout<<"MID POINT OF ("<<p_main.x1<<","<<p_main.y1<<") IS : "<<"("<<p_main.x1_mid<<","<<p_main.y1_mid<<")"<<endl;
    cout<<"MID POINT OF ("<<p_main.x2<<","<<p_main.y2<<") IS : "<<"("<<p_main.x2_mid<<","<<p_main.y2_mid<<")"<<endl;

    point p_first;
    p_first.x1 = p_main.x1; p_first.x1_mid = p_main.x1_mid;
    p_first.y1 = p_main.y1; p_first.y1_mid = p_main.y1_mid;

    point p_second;
    p_second.x2 = p_main.x2; p_second.x2_mid = p_main.x2_mid;
    p_second.y2 = p_main.y2; p_second.y2_mid = p_main.y2_mid;

    is_equal_to(p_first, p_second);

    is_greater_than(p_first, p_second);
}