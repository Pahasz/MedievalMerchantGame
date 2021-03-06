﻿namespace Assets.Scripts.BehaviourTree.Leaf
{
    public class GetUnitTargetFromQueue : LeafTask
    {
        public GetUnitTargetFromQueue(BlackBoard blackboard) : base(blackboard)
        {

        }

        public override void Start()
        {
            base.Start();

            if (this.bb.targetBuilding.UnitQueue.Count > 0)
            {
                this.bb.targetFootUnit = this.bb.targetBuilding.UnitQueue.Dequeue();
                this.controller.FinishWithSuccess();
            }
            else
                this.controller.FinishWithFailure();
        }
    }
}