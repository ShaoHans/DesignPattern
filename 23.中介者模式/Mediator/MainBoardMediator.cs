using System;
using System.Collections.Generic;
using System.Text;

namespace _23.中介者模式
{
    public class MainBoardMediator : Mediator
    {
        public HardDiskColleague HardDisk { get; set; }
        public CpuColleague Cpu { get; set; }
        public SoundCardColleague SoundCard { get; set; }
        public GraphicsCardColleague GraphicsCard { get; set; }


        public override void Change(Colleague colleague)
        {
            if(colleague is HardDiskColleague)
            {
                PlayMovie();
            }
            else
            {
                Cpu.Handle();
            }
        }

        private void PlayMovie()
        {
            HardDisk.ProvideMovieData();
            Cpu.Handle();
            SoundCard.Show();
            GraphicsCard.Play();
        }
    }
}
