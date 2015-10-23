﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Pulsar4X.ECSLib;

namespace Pulsar4X.ViewModel
{
    public class JobVM : IViewModel
    {
        private StaticDataStore _staticData;
        private JobBase _job;
        private Entity _colonyEntity;
        //private RefinaryAbilityVM _parentRefiningVM;

        public JobPriorityCommand JobPriorityCommand { get; set; }

        private int _jobTotalPoints;
        public string Item
        {
            get
            {
                if (_job is RefineingJob)
                    return _staticData.RefinedMaterials[_job.ItemGuid].Name;
                else if (_job is ConstructionJob)
                    return _colonyEntity.GetDataBlob<ColonyInfoDB>().FactionEntity.GetDataBlob<FactionInfoDB>().ComponentDesigns[_job.ItemGuid].GetDataBlob<NameDB>().DefaultName;
                else
                    return "Unknown Jobtype";

            }
        }

        public ushort Completed { get { return _job.NumberCompleted; } set { OnPropertyChanged(); } }
        public ushort BatchQuantity { get { return _job.NumberOrdered; } set { _job.NumberOrdered = value; OnPropertyChanged(); } }
        public bool Repeat { get { return _job.Auto; } set { _job.Auto = value; OnPropertyChanged(); } }
        //private int PriorityIndex { get { return _parentRefiningVM.ItemJobs.IndexOf(this); } set { OnPropertyChanged(); } }
        public int ItemBuildPointsRemaining { get { return _job.PointsLeft; } set { OnPropertyChanged(); } }
        public double ItemPercentRemaining { get { return (double)_job.PointsLeft / _jobTotalPoints * 100; } set { OnPropertyChanged(); } }



        public JobVM()
        {
            JobPriorityCommand = new JobPriorityCommand(this);
        }


        public JobVM(StaticDataStore staticData, Entity colonyEntity, JobBase job)//, RefinaryAbilityVM parentRefiningVM)
        {
            _staticData = staticData;
            _colonyEntity = colonyEntity;
            _job = job;
            //_parentRefiningVM = parentRefiningVM;

            if (_job is RefineingJob)
                _jobTotalPoints = _staticData.RefinedMaterials[_job.ItemGuid].RefinaryPointCost;
            else if (_job is ConstructionJob)
                _jobTotalPoints = _colonyEntity.GetDataBlob<ColonyInfoDB>().FactionEntity.GetDataBlob<FactionInfoDB>().ComponentDesigns[_job.ItemGuid].GetDataBlob<ComponentInfoDB>().BuildPointCost;


            JobPriorityCommand = new JobPriorityCommand(this);
        }

        public void ChangePriority(string direction)
        {
            int delta =0;
            if (direction == "up")
                delta = -1;
            else if (direction == "down")
                delta = 1;

            if (_job is RefineingJob)
                RefiningProcessor.ChangeJobPriority(_colonyEntity, (RefineingJob)_job, delta);
            //if (_job is ConstructionJob)
            //ConstructionJob.MoveJob(_colonyEntity, (ConstructionJob)_job, -1);

        }
        //public void DecresePriorty()
        //{
        //    if (PriorityIndex < _parentRefiningVM.ItemJobs.Count - 2)
        //    {
        //        if (_job is RefineingJob)
        //            RefiningProcessor.ChangeJobPriority(_colonyEntity, (RefineingJob)_job, 1);
        //    }
        //}


        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public void Refresh(bool partialRefresh = false)
        {
            if (PropertyChanged != null)
            {
                Completed = Completed;
                BatchQuantity = BatchQuantity;
                Repeat = Repeat;
                //PriorityIndex = PriorityIndex;
                ItemBuildPointsRemaining = ItemBuildPointsRemaining;
                ItemPercentRemaining = ItemPercentRemaining;

                //PropertyChanged(this, new PropertyChangedEventArgs("Completed"));
                //PropertyChanged(this, new PropertyChangedEventArgs("BatchQuantity"));
                //PropertyChanged(this, new PropertyChangedEventArgs("Repeat"));
                //PropertyChanged(this, new PropertyChangedEventArgs("ItemPercentRemaining"));
            }
        }
    }
}