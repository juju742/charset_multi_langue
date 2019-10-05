//  Author:
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

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Charset
{
    public class Special : Default
    {
               

        public List<string> ListHexa(string charsetName)
        {
            if (charsetName == "hex-lower")
            {
                //hex-lower
                charsetSelecting = Numeric.Concat(Hex_lower).ToList();                
            }
            else if (charsetName == "hex-upper")
            {
                //hex-upper 
                charsetSelecting = Numeric.Concat(Hex_upper).ToList();
            }
            
            return charsetSelecting;
        }

        public List<string> ListNumeric(string charsetName)
        {
            if (charsetName == "numeric")
            {
                //numeric
                charsetSelecting = Numeric;
            }
            else if (charsetName == "numeric-space")
            {
                //numeric-space
                charsetSelecting = Numeric.Concat(Space).ToList();
            }
            
            return charsetSelecting;
        }

        public List<string> ListSymbols(string charsetName)
        {
            if (charsetName == "symbols14")
            {
                //symbols14  
                charsetSelecting = Symbols14;                
            }
            else if (charsetName == "symbols14-space")
            {
                //symbols14-space
                charsetSelecting = Symbols14.Concat(Space).ToList();                
            }
            else if (charsetName == "symbols-all")
            {
                //symbols-all
                charsetSelecting = Symbols14.Concat(Symbols_all).ToList();                
            }
            else if (charsetName == "symbols-all-space")
            {
                //symbols-all-space
                charsetSelecting = Symbols14.Concat(Symbols_all).Concat(Space).ToList();
            }           

            return charsetSelecting;
        }
    }
}
