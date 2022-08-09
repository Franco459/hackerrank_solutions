using System;
using System.Linq;

class Person{
	protected string firstName;
	protected string lastName;
	protected int id;
	
	public Person(){}
	public Person(string firstName, string lastName, int identification){
			this.firstName = firstName;
			this.lastName = lastName;
			this.id = identification;
	}
	public void printPerson(){
		Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id); 
	}
}
/////////////////////SOLUTION/////////////////////
class Student : Person{
    private int[] testScores;  
    public Student(string firstName, string lastName, int id, int[] scores) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = id;
        this.testScores = scores;
    }
    // Write your method here
    public char Calculate(){
        var average = testScores.Average();
        switch(average){
        case < 40: return 'T'; break;
        case < 55: return 'D'; break;
        case < 70: return 'P'; break;
        case < 80: return 'A'; break;
        case < 90: return 'E'; break;
        default:   return 'O'; break;
        }
    }
}
/////////////////////SOLUTION/////////////////////

class Solution {
	static void Main() {
		string[] inputs = Console.ReadLine().Split();
		string firstName = inputs[0];
	  	string lastName = inputs[1];
		int id = Convert.ToInt32(inputs[2]);
		int numScores = Convert.ToInt32(Console.ReadLine());
		inputs = Console.ReadLine().Split();
	  	int[] scores = new int[numScores];
		for(int i = 0; i < numScores; i++){
			scores[i]= Convert.ToInt32(inputs[i]);
		} 
	  	
		Student s = new Student(firstName, lastName, id, scores);
		s.printPerson();
		Console.WriteLine("Grade: " + s.Calculate() + "\n");
	}
}