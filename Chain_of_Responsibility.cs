using System;

namespace Chain_of_Responsibility
{
    #region PeopleHandle

    public class PeopleHandle
    {
        private readonly PeopleHandle _successor;

        public PeopleHandle(PeopleHandle successor = null)
        {
            _successor = successor;
        }

        public virtual void GiveAnswerToQuestion()
        {
            if (_successor == null)
            {
                Console.WriteLine("I give answer on question");   
            }
            else
                _successor.GiveAnswerToQuestion();
        }
    }

    #endregion

    #region ProgrammerHandle

    public class ProgrammerHandle : PeopleHandle
    {
        private readonly PeopleHandle _successor;

        public ProgrammerHandle(PeopleHandle successor = null)
        {
            _successor = successor;
        }

        public override void GiveAnswerToQuestion()
        {
            if (_successor == null)
                Console.WriteLine("Programmer give answer on question");
            else
                _successor.GiveAnswerToQuestion();
        }
    }

    #endregion

    #region SeniorProgrammerHandle

    public class SeniorProgrammerHandle: PeopleHandle
    {
        private readonly PeopleHandle _successor;

        public SeniorProgrammerHandle(PeopleHandle successor = null)
        {
            _successor = successor;
        }

        public override void GiveAnswerToQuestion()
        {
            if (_successor == null)
                Console.WriteLine("Senior programmer give answer on question");
            else
                _successor.GiveAnswerToQuestion();
        }
    }

    #endregion

    #region MiddleProgrammerHandle

    public class MiddleProgrammerHandle : PeopleHandle
    {
        private readonly PeopleHandle _successor;

        public MiddleProgrammerHandle(PeopleHandle successor = null)
        {
            _successor = successor;
        }

        public override void GiveAnswerToQuestion()
        {
            if (_successor == null)
                Console.WriteLine("Middle programmer give answer on question");
            else
                _successor.GiveAnswerToQuestion();
        }
    }

    #endregion

    #region JuniorProgrammerHandle

    public class JuniorProgrammerHandle : PeopleHandle
    {
        private readonly PeopleHandle _successor;

        public JuniorProgrammerHandle(PeopleHandle successor = null)
        {
            _successor = successor;
        }

        public override void GiveAnswerToQuestion()
        {
            if (_successor == null)
                Console.WriteLine("Junior programmer give answer on question");
            else
                _successor.GiveAnswerToQuestion();
        }
    }

    #endregion
}
