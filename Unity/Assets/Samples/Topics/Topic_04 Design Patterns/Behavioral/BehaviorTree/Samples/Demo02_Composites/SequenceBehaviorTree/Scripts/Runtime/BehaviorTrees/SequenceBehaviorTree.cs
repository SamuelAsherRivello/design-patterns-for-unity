using System.Collections.Generic;
using RMC.Core.DesignPatterns.BehavioralPatterns.BehaviorTreePattern;


namespace RMC.BestPractices.DesignPatterns.BehavioralPatterns.BehaviorTreePattern.Sample
{
    public class SequenceBehaviorTree : BehaviorTree
    {
        /// <summary>
        /// Demo: See <see cref="Sequence_AkaAnd_Node"/> for expected behavior
        /// </summary>
        protected override Node CreateRootNode()
        {
            Node root = 
                new Sequence_AkaAnd_Node(new List<Node>
                {
                    new CountUpNode(3),
                    new CountUpNode(3),
                });

            return root;
        }
    }
}

