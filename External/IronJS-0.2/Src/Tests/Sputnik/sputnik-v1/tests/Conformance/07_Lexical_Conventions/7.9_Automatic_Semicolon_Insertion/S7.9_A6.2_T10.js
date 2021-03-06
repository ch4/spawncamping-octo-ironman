// Copyright 2009 the Sputnik authors.  All rights reserved.
// This code is governed by the BSD license found in the LICENSE file.

/**
 * @name: S7.9_A6.2_T10;
 * @section: 7.9, 12.6.3;
 * @assertion: Check For Statement for automatic semicolon insertion.
 * If automatic insertion semicolon would become one of the two semicolons in the header of a For Statement.
 * Use one semicolon;
 * @description: For header is (\n false \n semicolon);
 * @negative 
*/

//CHECK#1
for(
    false
;) {
  break;
}
