namespace YogurtBank.Models {

    public class Supervisor : User {

        public ICollection<Idea> ideas;

        public void PostIdea(Idea idea){};
        public void UpdateIdea(){};
        public ICollection<Idea> ViewMyIdeas(){};
    }

}


