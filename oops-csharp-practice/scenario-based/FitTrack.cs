using System;
using System.Collections.Generic;

    // Interface
    public interface ITrackable
    {
        double CalculateCalories();
        void DisplayWorkout();
    }

    // Base Class
    public abstract class Workout : ITrackable
    {
        public string WorkoutName { get; set; }
        public int DurationInMinutes { get; set; }

        public Workout(string name, int duration)
        {
            WorkoutName = name;
            DurationInMinutes = duration;
        }

        public abstract double CalculateCalories();

        public virtual void DisplayWorkout()
        {
            Console.WriteLine("Workout: "+WorkoutName);
            Console.WriteLine("Duration: "+DurationInMinutes+"minutes");
        }
    }

    // Cardio Workout
    public class CardioWorkout : Workout
    {
        public double DistanceInKm { get; set; }

        public CardioWorkout(string name, int duration, double distance)
            : base(name, duration)
        {
            DistanceInKm = distance;
        }

        public override double CalculateCalories()
        {
            // Approx: 60 calories per km
            return DistanceInKm * 60;
        }

        public override void DisplayWorkout()
        {
            base.DisplayWorkout();
            Console.WriteLine("Distance: "+DistanceInKm+" km");
            Console.WriteLine("Calories Burned: "+CalculateCalories());
            Console.WriteLine("------------------------------");
        }
    }

    // Strength Workout
    public class StrengthWorkout : Workout
    {
        public int Sets { get; set; }
        public int Reps { get; set; }

        public StrengthWorkout(string name, int duration, int sets, int reps)
            : base(name, duration)
        {
            Sets = sets;
            Reps = reps;
        }

        public override double CalculateCalories()
        {
            // Approx: 5 calories per minute per set
            return DurationInMinutes * Sets * 5;
        }

        public override void DisplayWorkout()
        {
            base.DisplayWorkout();
            Console.WriteLine("Sets: "+Sets+", "+Reps+": "+Reps);
            Console.WriteLine("Calories Burned: "+CalculateCalories());
            Console.WriteLine("------------------------------");
        }
    }

    // User Profile Class
    public class UserProfile
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        private List<Workout> workouts = new List<Workout>();

        public UserProfile(int userId, string name)
        {
            UserId = userId;
            Name = name;
        }

        public void AddWorkout(Workout workout)
        {
            workouts.Add(workout);
            Console.WriteLine("Workout added successfully!\n");
        }

        public void ShowWorkoutHistory()
        {
            Console.WriteLine("=== Workout History for "+Name+" ===");

            if (workouts.Count == 0)
            {
                Console.WriteLine("No workouts found.");
                return;
            }

            foreach (Workout w in workouts)
            {
                w.DisplayWorkout(); // Polymorphism
            }
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            // Create User
            UserProfile user = new UserProfile(1, "Harsh");

            // Create Workouts
            Workout cardio = new CardioWorkout("Morning Run", 30, 4.5);
            Workout strength = new StrengthWorkout("Weight Training", 45, 4, 12);

            // Add Workouts
            user.AddWorkout(cardio);
            user.AddWorkout(strength);

            // Display Workout History
            user.ShowWorkoutHistory();

            Console.ReadLine();
        }
    }
