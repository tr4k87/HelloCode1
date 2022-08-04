Console.Clear();
int count = 0;
int distance = 10;
int FirstFriendSpeed = 1;
int SecondFriendSpeed = 2;
int DogSpeed = 3;
int Friend = 2;
int Time = 0;

while (distance > 1)
{   
    if (Friend == 1)
    {
        Time = distance/(FirstFriendSpeed+DogSpeed);
    
    Friend = 2;
    }

    else
    {
        Time=distance/(SecondFriendSpeed+DogSpeed);

    Friend = 1;
    }
distance = distance - (FirstFriendSpeed+SecondFriendSpeed) * Time;

count = count + 1;
}

Console.Write("Собака пробежит ");

Console.Write(count);

Console.WriteLine(" раз");