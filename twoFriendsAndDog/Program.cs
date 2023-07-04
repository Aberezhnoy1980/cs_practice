Console.Clear();
Console.WriteLine("Please, answer Yes or No: Are friends oncoming to each other?");
string direction = Console.ReadLine().ToLower();
bool value;
// direction.Equals("yes") ? value = true : value = false;
if (direction.Equals("yes"))
{
    value = true;
} else value = false;

int distance = 10000;
int meetingDistance = 10;
int firstFriendSpeed = 2;
int secondFriendSpeed = 1;
int dogSpeed = 5;
int count = 0;
bool isSecondFriend = true;
bool isOncomingTraffic = value;
int time = 0;

while (distance > meetingDistance)
{
    if (isOncomingTraffic)
    {
        if (isSecondFriend)
        {
            time = distance / (secondFriendSpeed + dogSpeed);
            distance -= (firstFriendSpeed + secondFriendSpeed) * time;
            isSecondFriend = false;
            count++;
        }
        else
        {
            time = distance / (firstFriendSpeed + dogSpeed);
            distance -= (firstFriendSpeed + secondFriendSpeed) * time;
            isSecondFriend = true;
            count++;
        }
    }
    else
    {
        if (isSecondFriend)
        {
            time = distance / (dogSpeed + secondFriendSpeed);
            distance -= (secondFriendSpeed - firstFriendSpeed) * time;
            isSecondFriend = false;
            count++;
        }
        else
        {
            time = distance / (dogSpeed - firstFriendSpeed);
            distance -= (secondFriendSpeed - firstFriendSpeed) * time;
            isSecondFriend = true;
            count++;
        }
    }
}

Console.WriteLine("Dog run between friends " + count + " times");
