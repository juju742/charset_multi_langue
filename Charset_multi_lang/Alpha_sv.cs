﻿//  Author:
//       Julien Dubromez <j.dubromez.it@gmail.com>
//
//  Copyright (c) 2014 Julien Dubromez
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General public License for more details.
//
//  You should have received a copy of the GNU General public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System.Collections.Generic;
using System.Linq;

namespace Charset
{
    public class Alpha_sv : Default
    {

        public List<string> Lalpha_svList(string charsetName)
        {

            if (charsetName == "sv-lalpha")
            {
                charsetSelecting = Lalpha.Concat(Lalpha_sv).ToList();               
            }
            else if (charsetName == "sv-lalpha-space")
            {
                charsetSelecting = Lalpha.Concat(Lalpha_sv).Concat(Space).ToList();                
            }
            else if (charsetName == "sv-lalpha-numeric")
            {
                charsetSelecting = Lalpha.Concat(Lalpha_sv).Concat(Numeric).ToList();                

            }
            else if (charsetName == "sv-lalpha-numeric-space")
            {
                charsetSelecting = Lalpha.Concat(Lalpha_sv).Concat(Numeric).Concat(Space).ToList();
                
            }
            else if (charsetName == "sv-lalpha-numeric-symbol14")
            {
                charsetSelecting = Lalpha.Concat(Lalpha_sv).Concat(Numeric).Concat(Symbols14).ToList();
                
            }
            else if (charsetName == "sv-lalpha-numeric-symbol14-space")
            {
                charsetSelecting = Lalpha.Concat(Lalpha_sv).Concat(Numeric).Concat(Symbols14).Concat(Space).ToList();
                
            }
            else if (charsetName == "sv-lalpha-numeric-all")
            {
                charsetSelecting = Lalpha.Concat(Lalpha_sv).Concat(Numeric).Concat(Symbols14).Concat(Symbols_all).ToList();
                
            }
            else if (charsetName == "sv-lalpha-numeric-all-space")
            {
                charsetSelecting = Lalpha.Concat(Lalpha_sv).Concat(Numeric).Concat(Symbols14).Concat(Symbols_all).Concat(Space).ToList();                    
               
            }
            
            return charsetSelecting;
        }

        public  List<string> Ualpha_svList(string charsetName)
        {

            if (charsetName == "sv-ualpha")
            {
                //ualpha-sv
                charsetSelecting = Ualpha.Concat(Ualpha_sv).ToList();
                           }
            else if (charsetName == "sv-ualpha-space")
            {
                //ualpha-space-sv
                charsetSelecting = Ualpha.Concat(Ualpha_sv).Concat(Space).ToList();
                
            }
            else if (charsetName == "sv-ualpha-numeric")
            {
                //ualpha-numeric-sv
                charsetSelecting = Ualpha.Concat(Ualpha_sv).Concat(Numeric).ToList();

            }
            else if (charsetName == "sv-ualpha-numeric-space")
            {
                //ualpha-numeric-space-sv
                charsetSelecting = Ualpha.Concat(Ualpha_sv).Concat(Numeric).Concat(Space).ToList();

            }
            else if (charsetName == "sv-ualpha-numeric-symbol14")
            {
                //ualpha-numeric-symbol14-sv
                charsetSelecting = Ualpha.Concat(Ualpha_sv).Concat(Numeric).Concat(Symbols14).ToList();

            }
            else if (charsetName == "sv-ualpha-numeric-symbol14-space")
            {
                //ualpha-numeric-symbol14-space-sv
                charsetSelecting = Ualpha.Concat(Ualpha_sv).Concat(Numeric).Concat(Symbols14).Concat(Space).ToList();

            }
            else if (charsetName == "sv-ualpha-numeric-all")
            {
                //ualpha-numeric-all-sv
                charsetSelecting = Ualpha.Concat(Ualpha_sv).Concat(Numeric).Concat(Symbols14).Concat(Symbols_all).ToList();

            }
            else if (charsetName == "sv-ualpha-numeric-all-space")
            {
                //ualpha-numeric-all-space-sv
                charsetSelecting = Ualpha.Concat(Ualpha_sv).Concat(Numeric).Concat(Symbols14).Concat(Symbols_all).Concat(Space).ToList();

            }
           
            return charsetSelecting;
        }



        public List<string> MixAlpha_svList(string charsetName)
        {

            if (charsetName == "sv-mixalpha")
            {
                //mixalpha-sv
                charsetSelecting = Lalpha.Concat(Lalpha_sv).Concat(Ualpha).Concat(Ualpha_sv).ToList();

            }
            else if (charsetName == "sv-mixalpha-space")
            {
                //mixalpha-space-sv
                charsetSelecting = Lalpha.Concat(Lalpha_sv).Concat(Ualpha).Concat(Ualpha_sv).Concat(Space).ToList();

            }
            else if (charsetName == "sv-mixalpha-numeric")
            {
                // mixalpha-numeric-sv
                charsetSelecting = Lalpha.Concat(Lalpha_sv).Concat(Ualpha).Concat(Ualpha_sv).Concat(Numeric).ToList();
            }
            else if (charsetName == "sv-mixalpha-numeric-space")
            {
                //mixalpha-numeric-space_sv
                charsetSelecting = Lalpha.Concat(Lalpha_sv).Concat(Ualpha).Concat(Ualpha_sv).Concat(Numeric).Concat(Space).ToList();

            }
            else if (charsetName == "sv-mixalpha-numeric-symbol14")
            {
                //mixalpha-numeric-symbol14-sv
                charsetSelecting = Lalpha.Concat(Lalpha_sv).Concat(Ualpha).Concat(Ualpha_sv).Concat(Numeric).Concat(Symbols14).ToList();

            }
            else if (charsetName == "sv-mixalpha-numeric-symbol14-space")
            {
                //mixalpha-numeric-symbol14-space-sv
                charsetSelecting = Lalpha.Concat(Lalpha_sv).Concat(Ualpha).Concat(Ualpha_sv).Concat(Numeric).Concat(Symbols14).Concat(Space).ToList();

            }
            else if (charsetName == "sv-mixalpha-numeric-all")
            {
                //mixalpha-numeric-all-sv
                charsetSelecting = Lalpha.Concat(Lalpha_sv).Concat(Ualpha).Concat(Ualpha_sv).Concat(Numeric).Concat(Symbols14).Concat(Symbols_all).ToList();

            }
            else if (charsetName == "sv-mixalpha-numeric-all-space")
            {
                //mixalpha-numeric-all-space-sv
                charsetSelecting = Lalpha.Concat(Lalpha_sv).Concat(Ualpha).Concat(Ualpha_sv).Concat(Numeric).Concat(Symbols14).Concat(Symbols_all).Concat(Space).ToList();

            }
            
            return charsetSelecting;

        }
    }
}
