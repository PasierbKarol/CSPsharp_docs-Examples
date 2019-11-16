//////////////////////////////////////////////////////////////////////
//                                                                  //
//  jcspDemos Demonstrations of the JCSP ("CSP for Java") Library   //
//  Copyright (C) 1996-2018 Peter Welch, Paul Austin and Neil Brown //
//                2001-2004 Quickstone Technologies Limited         //
//                2005-2018 Kevin Chalmers                          //
//                                                                  //
//  You may use this work under the terms of either                 //
//  1. The Apache License, Version 2.0                              //
//  2. or (at your option), the GNU Lesser General Public License,  //
//       version 2.1 or greater.                                    //
//                                                                  //
//  Full licence texts are included in the LICENCE file with        //
//  this library.                                                   //
//                                                                  //
//  Author contacts: P.H.Welch@kent.ac.uk K.Chalmers@napier.ac.uk   //
//                                                                  //
//////////////////////////////////////////////////////////////////////

using System;
using CSPlang;

namespace Canteen_Alternative_With_Preconditions_Example
{
    /**
     * @author P.H. Welch
     */
    class Clock : IamCSProcess
    {
        public void run()
        {
            CSTimer timer = new CSTimer();
            int tick = 0;

            while (true)
            {
                Console.WriteLine("[TICK] " + tick);
                timer.sleep(1000);
                tick++;
            }
        }
    }
}