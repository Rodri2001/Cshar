// Cosas basicas para poder programar un video juego
// nota de lo mas importante en C# siempre terminar el codigo
// con punto y coma ;

//para declarar variables 
//integer, float ,sting , boolean
//int para declarar tipo let 

init score;
score = 100;

// float sirve para numeros decimales 

float score2 = 00.1;

// bool es para declarar variables del tipo boolean
bool okey = true || false;


int morescore = 50;
// operar con variables 
//int total = score + morescore;
//int total = score - morescore;
//int total = score / morescore;

score += 10; // 110
score++; // +1 queda 111

//array
// valores especificos
string[] names = { "Mario", "Luigi" };
// valores entero
int number = new init[1, 2, 3];
// declaracion de array en cadena 
string[] nombres = new string[3];

string mainCharacter;
mainCharacter = names[0]; // agarra el primero dela lista names[0] ahora maincharacter es mario

//operadores condicionales 
bool win;
int morescore;

if (score == 500 || morescore > 100) // las condiciones funcionan igual que en javascript 
{
    win = true;
}
else
{
    win = false;
}
// otro operador condicional es el while 

// mientras que score se mayor a 1 restale 1
while (score > 0)
{
    score--;
}

// for es otro operador condicional 
//  la primera es la inicializacion de la variable
// la segunda sentencia es la condicion que se tiene que cumplir para que el bucle se repita
// y la tercera es lo que queremos que haga en este caso queremos que le sume 1 a i
for (int i = 0; i < 3; i++)
{
    score++;
}

string[] names = { "Mario", "Luigi", "Bowser" };


// lo que hace este codigo es agregarle un . a cada elemento del array

for (int i = 0; i < 3; i++)
{
    names[i] += ".";
}

// funciones 
// una funcion para preder o apagar la luz

bool light;

// void es la palabra magica para poder crear funciones en C#
// lo unico que se puede declarar fuera de las funciones son las variables
// la razones la misma vive y muere en su scope


void Switch()
{
    if (light == false)
    {
        light = true;
    }
    else
    {
        light = false;
    }

}

// pasar propiedad por parametros

void ScoreManager (){
    int score = 0;
    // de esta manera solo pasamos el valor de la variable 
  // pero si le decimos a score que se guarde la informacion de la funcion mantiene el valor  
 score = AddOne(score);
}

void AddOne (int a){
    // a es score y se le esta sumando 1
    a++;
    // en este caso es importante devolver el valor , para que no se pierda en el limbo
    return a;
}

