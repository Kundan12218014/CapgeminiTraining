using System;
class AddGenericClass<T>//Generic class
{
  //generic variable
  T n1;
  T n2;
  T result;

  public T GenericProperty{ get; set; }
  //generic constructor
  public AddGenericClass(T m,T n){//generic Constructor
  this.n1=m;
  this.n2=n;
  }
  //generic Default Constructor
  public AddGenericClass(){

  }
  //generic parametrixed Constructor
  public T AddAllType(T num1,T num2)
  {
    n1=num1;
    n2=num2;
    dynamic x=num1;
    dynamic y=num2;
    result = x+y;
    return result;
  }
}