<Query Kind="Program" />

// https://leetcode.com/problems/course-schedule-ii/

void Main()
{
	//var pr = new int[][] { new[] { 0, 1 }, new[] { 1, 0 } };
	//var pr = new int[][] { new[] { 1, 0 } };
	//var pr = new int[][] { new[] { 1, 0 }, new[] { 2, 0 }, new[] { 0, 2 } };
	var pr = new int[][] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 1, 2 } };
	//var pr = new int[][] { new[] { 695, 229 }, new[] { 199, 149 }, new[] { 443, 397 }, new[] { 258, 247 }, new[] { 781, 667 }, new[] { 350, 160 }, new[] { 678, 629 }, new[] { 467, 166 }, new[] { 500, 450 }, new[] { 477, 107 }, new[] { 483, 151 }, new[] { 792, 785 }, new[] { 752, 368 }, new[] { 659, 623 }, new[] { 316, 224 }, new[] { 487, 268 }, new[] { 743, 206 }, new[] { 552, 211 }, new[] { 314, 20 }, new[] { 720, 196 }, new[] { 421, 103 }, new[] { 493, 288 }, new[] { 762, 24 }, new[] { 528, 318 }, new[] { 472, 32 }, new[] { 684, 502 }, new[] { 641, 354 }, new[] { 586, 480 }, new[] { 629, 54 }, new[] { 611, 412 }, new[] { 719, 680 }, new[] { 733, 42 }, new[] { 549, 519 }, new[] { 697, 316 }, new[] { 791, 634 }, new[] { 546, 70 }, new[] { 676, 587 }, new[] { 460, 58 }, new[] { 605, 530 }, new[] { 617, 579 }, new[] { 484, 89 }, new[] { 571, 482 }, new[] { 767, 200 }, new[] { 555, 547 }, new[] { 771, 695 }, new[] { 624, 542 }, new[] { 708, 551 }, new[] { 432, 266 }, new[] { 656, 468 }, new[] { 724, 317 }, new[] { 423, 248 }, new[] { 621, 593 }, new[] { 781, 399 }, new[] { 535, 528 }, new[] { 578, 12 }, new[] { 770, 549 }, new[] { 576, 295 }, new[] { 318, 247 }, new[] { 400, 372 }, new[] { 465, 363 }, new[] { 786, 482 }, new[] { 441, 398 }, new[] { 577, 411 }, new[] { 524, 30 }, new[] { 741, 540 }, new[] { 459, 59 }, new[] { 758, 96 }, new[] { 550, 89 }, new[] { 402, 295 }, new[] { 476, 336 }, new[] { 645, 346 }, new[] { 750, 116 }, new[] { 551, 207 }, new[] { 343, 226 }, new[] { 568, 498 }, new[] { 530, 228 }, new[] { 525, 84 }, new[] { 507, 128 }, new[] { 526, 210 }, new[] { 535, 381 }, new[] { 635, 330 }, new[] { 654, 535 }, new[] { 710, 275 }, new[] { 397, 213 }, new[] { 412, 44 }, new[] { 131, 70 }, new[] { 508, 49 }, new[] { 679, 223 }, new[] { 519, 11 }, new[] { 626, 286 }, new[] { 242, 160 }, new[] { 778, 199 }, new[] { 606, 281 }, new[] { 226, 16 }, new[] { 340, 46 }, new[] { 578, 127 }, new[] { 212, 208 }, new[] { 674, 343 }, new[] { 778, 108 }, new[] { 749, 451 }, new[] { 735, 105 }, new[] { 544, 131 }, new[] { 600, 229 }, new[] { 691, 314 }, new[] { 608, 74 }, new[] { 613, 491 }, new[] { 754, 500 }, new[] { 722, 449 }, new[] { 486, 11 }, new[] { 786, 70 }, new[] { 212, 23 }, new[] { 717, 11 }, new[] { 692, 410 }, new[] { 503, 157 }, new[] { 783, 177 }, new[] { 220, 215 }, new[] { 419, 363 }, new[] { 182, 17 }, new[] { 321, 54 }, new[] { 711, 78 }, new[] { 312, 106 }, new[] { 560, 101 }, new[] { 501, 178 }, new[] { 583, 403 }, new[] { 577, 9 }, new[] { 595, 227 }, new[] { 601, 386 }, new[] { 792, 619 }, new[] { 550, 167 }, new[] { 589, 431 }, new[] { 793, 243 }, new[] { 395, 76 }, new[] { 197, 3 }, new[] { 357, 6 }, new[] { 763, 7 }, new[] { 599, 48 }, new[] { 178, 92 }, new[] { 325, 307 }, new[] { 620, 10 }, new[] { 334, 117 }, new[] { 556, 296 }, new[] { 454, 394 }, new[] { 485, 236 }, new[] { 140, 80 }, new[] { 404, 301 }, new[] { 651, 58 }, new[] { 504, 455 }, new[] { 101, 93 }, new[] { 712, 42 }, new[] { 559, 421 }, new[] { 594, 230 }, new[] { 505, 98 }, new[] { 719, 654 }, new[] { 672, 283 }, new[] { 109, 73 }, new[] { 556, 183 }, new[] { 617, 94 }, new[] { 133, 100 }, new[] { 771, 515 }, new[] { 613, 587 }, new[] { 285, 50 }, new[] { 579, 432 }, new[] { 282, 244 }, new[] { 669, 527 }, new[] { 783, 494 }, new[] { 628, 560 }, new[] { 716, 661 }, new[] { 177, 127 }, new[] { 430, 166 }, new[] { 383, 159 }, new[] { 746, 19 }, new[] { 653, 284 }, new[] { 495, 243 }, new[] { 376, 57 }, new[] { 560, 143 }, new[] { 679, 198 }, new[] { 751, 355 }, new[] { 339, 157 }, new[] { 409, 140 }, new[] { 729, 389 }, new[] { 518, 315 }, new[] { 623, 352 }, new[] { 651, 133 }, new[] { 761, 269 }, new[] { 442, 44 }, new[] { 379, 245 }, new[] { 313, 180 }, new[] { 773, 583 }, new[] { 291, 221 }, new[] { 271, 54 }, new[] { 799, 44 }, new[] { 200, 102 }, new[] { 568, 67 }, new[] { 695, 167 }, new[] { 327, 36 }, new[] { 431, 73 }, new[] { 782, 167 }, new[] { 611, 129 }, new[] { 630, 122 }, new[] { 563, 497 }, new[] { 697, 93 }, new[] { 596, 436 }, new[] { 611, 131 }, new[] { 627, 256 }, new[] { 658, 559 }, new[] { 591, 419 }, new[] { 193, 156 }, new[] { 302, 52 }, new[] { 409, 33 }, new[] { 405, 249 }, new[] { 384, 151 }, new[] { 214, 142 }, new[] { 558, 164 }, new[] { 565, 557 }, new[] { 492, 445 }, new[] { 681, 271 }, new[] { 797, 396 }, new[] { 251, 195 }, new[] { 784, 266 }, new[] { 607, 179 }, new[] { 671, 30 }, new[] { 752, 179 }, new[] { 787, 390 }, new[] { 749, 532 }, new[] { 618, 220 }, new[] { 659, 298 }, new[] { 567, 134 }, new[] { 229, 208 }, new[] { 298, 147 }, new[] { 787, 459 }, new[] { 572, 359 }, new[] { 794, 351 }, new[] { 53, 14 }, new[] { 646, 422 }, new[] { 234, 66 }, new[] { 274, 255 }, new[] { 744, 626 }, new[] { 730, 462 }, new[] { 498, 428 }, new[] { 573, 288 }, new[] { 688, 355 }, new[] { 603, 25 }, new[] { 191, 16 }, new[] { 793, 544 }, new[] { 750, 682 }, new[] { 415, 156 }, new[] { 460, 209 }, new[] { 749, 85 }, new[] { 269, 186 }, new[] { 441, 338 }, new[] { 319, 278 }, new[] { 505, 18 }, new[] { 672, 260 }, new[] { 420, 233 }, new[] { 493, 134 }, new[] { 493, 19 }, new[] { 308, 302 }, new[] { 582, 282 }, new[] { 755, 60 }, new[] { 641, 626 }, new[] { 669, 69 }, new[] { 772, 29 }, new[] { 132, 111 }, new[] { 666, 120 }, new[] { 605, 58 }, new[] { 534, 252 }, new[] { 636, 491 }, new[] { 777, 3 }, new[] { 602, 368 }, new[] { 533, 287 }, new[] { 401, 147 }, new[] { 782, 669 }, new[] { 517, 161 }, new[] { 686, 49 }, new[] { 789, 639 }, new[] { 776, 379 }, new[] { 376, 65 }, new[] { 696, 545 }, new[] { 423, 81 }, new[] { 448, 336 }, new[] { 631, 605 }, new[] { 501, 387 }, new[] { 413, 94 }, new[] { 777, 563 }, new[] { 661, 332 }, new[] { 756, 359 }, new[] { 646, 36 }, new[] { 650, 283 }, new[] { 656, 347 }, new[] { 522, 7 }, new[] { 383, 382 }, new[] { 438, 102 }, new[] { 762, 305 }, new[] { 650, 15 }, new[] { 249, 180 }, new[] { 784, 467 }, new[] { 763, 122 }, new[] { 163, 115 }, new[] { 775, 734 }, new[] { 166, 132 }, new[] { 634, 2 }, new[] { 668, 584 }, new[] { 767, 274 }, new[] { 595, 552 }, new[] { 11, 7 }, new[] { 693, 407 }, new[] { 789, 751 }, new[] { 613, 556 }, new[] { 715, 402 }, new[] { 751, 516 }, new[] { 646, 199 }, new[] { 625, 52 }, new[] { 572, 106 }, new[] { 724, 332 }, new[] { 617, 409 }, new[] { 573, 526 }, new[] { 760, 18 }, new[] { 382, 202 }, new[] { 207, 139 }, new[] { 416, 392 }, new[] { 672, 358 }, new[] { 233, 212 }, new[] { 668, 22 }, new[] { 765, 452 }, new[] { 294, 76 }, new[] { 259, 47 }, new[] { 593, 271 }, new[] { 510, 450 }, new[] { 592, 132 }, new[] { 770, 558 }, new[] { 296, 43 }, new[] { 419, 86 }, new[] { 752, 347 }, new[] { 615, 605 }, new[] { 635, 554 }, new[] { 794, 635 }, new[] { 613, 316 }, new[] { 563, 61 }, new[] { 770, 715 }, new[] { 771, 251 }, new[] { 646, 582 }, new[] { 423, 79 }, new[] { 576, 249 }, new[] { 604, 97 }, new[] { 767, 348 }, new[] { 736, 239 }, new[] { 775, 56 }, new[] { 619, 601 }, new[] { 790, 546 }, new[] { 531, 384 }, new[] { 507, 84 }, new[] { 564, 337 }, new[] { 432, 310 }, new[] { 600, 543 }, new[] { 747, 341 }, new[] { 556, 392 }, new[] { 661, 113 }, new[] { 449, 282 }, new[] { 575, 288 }, new[] { 637, 7 }, new[] { 635, 325 }, new[] { 735, 574 }, new[] { 574, 387 }, new[] { 705, 603 }, new[] { 704, 15 }, new[] { 684, 588 }, new[] { 495, 132 }, new[] { 718, 223 }, new[] { 517, 206 }, new[] { 272, 34 }, new[] { 677, 416 }, new[] { 788, 167 }, new[] { 649, 525 }, new[] { 619, 427 }, new[] { 541, 277 }, new[] { 489, 405 }, new[] { 608, 259 }, new[] { 603, 264 }, new[] { 435, 317 }, new[] { 623, 26 }, new[] { 544, 511 }, new[] { 72, 69 }, new[] { 623, 17 }, new[] { 600, 544 }, new[] { 551, 367 }, new[] { 404, 52 }, new[] { 324, 272 }, new[] { 706, 205 }, new[] { 778, 446 }, new[] { 341, 155 }, new[] { 581, 173 }, new[] { 666, 192 }, new[] { 588, 529 }, new[] { 554, 506 }, new[] { 250, 39 }, new[] { 772, 116 }, new[] { 569, 77 }, new[] { 526, 132 }, new[] { 563, 221 }, new[] { 655, 597 }, new[] { 649, 224 }, new[] { 57, 4 }, new[] { 679, 199 }, new[] { 265, 157 }, new[] { 380, 335 }, new[] { 558, 35 }, new[] { 726, 388 }, new[] { 763, 567 }, new[] { 437, 426 }, new[] { 643, 103 }, new[] { 773, 181 }, new[] { 726, 68 }, new[] { 164, 50 }, new[] { 717, 427 }, new[] { 681, 618 }, new[] { 477, 172 }, new[] { 697, 423 }, new[] { 525, 383 }, new[] { 794, 132 }, new[] { 149, 70 }, new[] { 704, 414 }, new[] { 581, 139 }, new[] { 678, 204 }, new[] { 107, 46 }, new[] { 352, 68 }, new[] { 645, 178 }, new[] { 758, 156 }, new[] { 627, 365 }, new[] { 331, 144 }, new[] { 547, 340 }, new[] { 788, 36 }, new[] { 633, 259 }, new[] { 588, 66 }, new[] { 321, 102 }, new[] { 528, 322 }, new[] { 212, 36 }, new[] { 288, 179 }, new[] { 434, 189 }, new[] { 749, 490 }, new[] { 753, 508 }, new[] { 784, 341 }, new[] { 550, 159 }, new[] { 741, 206 }, new[] { 758, 688 }, new[] { 766, 758 }, new[] { 586, 70 }, new[] { 657, 654 }, new[] { 701, 104 }, new[] { 548, 184 }, new[] { 613, 162 }, new[] { 620, 320 }, new[] { 506, 430 }, new[] { 517, 65 }, new[] { 571, 291 }, new[] { 771, 517 }, new[] { 796, 756 }, new[] { 735, 459 }, new[] { 625, 367 }, new[] { 759, 345 }, new[] { 582, 468 }, new[] { 469, 73 }, new[] { 790, 352 }, new[] { 493, 284 }, new[] { 664, 567 }, new[] { 342, 207 }, new[] { 669, 108 }, new[] { 611, 182 }, new[] { 764, 485 }, new[] { 214, 102 }, new[] { 544, 202 }, new[] { 713, 447 }, new[] { 793, 378 }, new[] { 147, 129 }, new[] { 407, 198 }, new[] { 608, 271 }, new[] { 695, 667 }, new[] { 680, 277 }, new[] { 222, 163 }, new[] { 744, 527 }, new[] { 280, 116 }, new[] { 430, 367 }, new[] { 281, 228 }, new[] { 688, 488 }, new[] { 733, 92 }, new[] { 529, 190 }, new[] { 750, 718 }, new[] { 793, 99 }, new[] { 626, 169 }, new[] { 486, 329 }, new[] { 620, 0 }, new[] { 782, 460 }, new[] { 329, 16 }, new[] { 753, 142 }, new[] { 338, 172 }, new[] { 518, 361 }, new[] { 688, 168 }, new[] { 497, 490 }, new[] { 484, 365 }, new[] { 365, 325 }, new[] { 107, 98 }, new[] { 622, 407 }, new[] { 527, 277 }, new[] { 659, 74 }, new[] { 552, 538 }, new[] { 493, 469 }, new[] { 638, 147 }, new[] { 304, 3 }, new[] { 573, 201 }, new[] { 411, 169 }, new[] { 719, 309 }, new[] { 287, 160 }, new[] { 742, 175 }, new[] { 573, 299 }, new[] { 562, 473 }, new[] { 705, 328 }, new[] { 261, 98 }, new[] { 580, 203 }, new[] { 740, 26 }, new[] { 418, 296 }, new[] { 764, 170 }, new[] { 656, 89 }, new[] { 724, 536 }, new[] { 730, 91 }, new[] { 796, 290 }, new[] { 735, 270 }, new[] { 512, 20 }, new[] { 402, 246 }, new[] { 46, 30 }, new[] { 426, 290 }, new[] { 296, 57 }, new[] { 725, 222 }, new[] { 324, 317 }, new[] { 547, 0 }, new[] { 661, 136 }, new[] { 636, 271 }, new[] { 261, 56 }, new[] { 750, 668 }, new[] { 647, 402 }, new[] { 773, 390 }, new[] { 677, 62 }, new[] { 249, 53 }, new[] { 574, 4 }, new[] { 393, 304 }, new[] { 701, 44 }, new[] { 109, 66 }, new[] { 275, 109 }, new[] { 679, 509 }, new[] { 725, 21 }, new[] { 409, 311 }, new[] { 368, 156 }, new[] { 605, 514 }, new[] { 538, 42 }, new[] { 690, 602 }, new[] { 411, 343 }, new[] { 424, 240 }, new[] { 78, 40 }, new[] { 750, 273 }, new[] { 367, 230 }, new[] { 167, 58 }, new[] { 738, 200 }, new[] { 634, 341 }, new[] { 409, 170 }, new[] { 644, 373 }, new[] { 741, 296 }, new[] { 702, 342 }, new[] { 746, 233 }, new[] { 411, 67 }, new[] { 526, 436 }, new[] { 796, 438 }, new[] { 647, 312 }, new[] { 717, 347 }, new[] { 548, 54 }, new[] { 725, 50 }, new[] { 549, 92 }, new[] { 610, 294 }, new[] { 668, 350 }, new[] { 578, 445 }, new[] { 446, 93 }, new[] { 727, 246 }, new[] { 526, 355 }, new[] { 344, 246 }, new[] { 145, 54 }, new[] { 355, 256 }, new[] { 751, 46 }, new[] { 454, 271 }, new[] { 587, 49 }, new[] { 728, 79 }, new[] { 627, 49 }, new[] { 522, 260 }, new[] { 270, 250 }, new[] { 491, 113 }, new[] { 337, 258 }, new[] { 609, 470 }, new[] { 387, 147 }, new[] { 656, 237 }, new[] { 366, 357 }, new[] { 160, 98 }, new[] { 761, 692 }, new[] { 753, 627 }, new[] { 718, 5 }, new[] { 335, 22 }, new[] { 640, 78 }, new[] { 687, 317 }, new[] { 315, 295 }, new[] { 471, 93 }, new[] { 481, 147 }, new[] { 724, 580 }, new[] { 687, 177 }, new[] { 409, 41 }, new[] { 355, 276 }, new[] { 393, 366 }, new[] { 770, 85 }, new[] { 697, 358 }, new[] { 187, 115 }, new[] { 671, 318 }, new[] { 716, 530 }, new[] { 767, 140 }, new[] { 566, 543 }, new[] { 318, 238 }, new[] { 341, 336 }, new[] { 648, 204 }, new[] { 496, 202 }, new[] { 505, 191 }, new[] { 360, 32 }, new[] { 408, 138 }, new[] { 537, 489 }, new[] { 668, 102 }, new[] { 400, 9 }, new[] { 472, 3 }, new[] { 727, 469 }, new[] { 713, 5 }, new[] { 530, 292 }, new[] { 465, 381 }, new[] { 551, 262 }, new[] { 514, 227 }, new[] { 394, 315 }, new[] { 551, 121 }, new[] { 655, 402 }, new[] { 755, 83 }, new[] { 153, 144 }, new[] { 303, 60 }, new[] { 766, 578 }, new[] { 668, 527 }, new[] { 796, 391 }, new[] { 692, 571 }, new[] { 617, 616 }, new[] { 229, 154 }, new[] { 798, 690 }, new[] { 706, 504 }, new[] { 610, 569 }, new[] { 655, 624 }, new[] { 408, 108 }, new[] { 569, 463 }, new[] { 461, 151 }, new[] { 507, 13 }, new[] { 781, 314 }, new[] { 780, 469 }, new[] { 506, 171 }, new[] { 552, 312 }, new[] { 189, 164 }, new[] { 336, 171 }, new[] { 571, 432 }, new[] { 688, 224 }, new[] { 160, 119 }, new[] { 470, 311 }, new[] { 663, 114 }, new[] { 665, 420 }, new[] { 556, 492 }, new[] { 709, 358 }, new[] { 202, 99 }, new[] { 170, 149 }, new[] { 340, 154 }, new[] { 666, 385 }, new[] { 617, 383 }, new[] { 502, 132 }, new[] { 220, 42 }, new[] { 778, 393 }, new[] { 444, 68 }, new[] { 526, 357 }, new[] { 217, 7 }, new[] { 597, 76 }, new[] { 586, 406 }, new[] { 481, 44 }, new[] { 486, 240 }, new[] { 513, 217 }, new[] { 790, 447 }, new[] { 275, 245 }, new[] { 396, 1 }, new[] { 369, 224 }, new[] { 485, 159 }, new[] { 680, 151 }, new[] { 387, 312 }, new[] { 721, 70 }, new[] { 733, 25 }, new[] { 457, 216 }, new[] { 798, 297 }, new[] { 329, 169 }, new[] { 766, 212 }, new[] { 286, 160 }, new[] { 703, 164 }, new[] { 765, 77 }, new[] { 620, 142 }, new[] { 510, 35 }, new[] { 475, 400 }, new[] { 784, 8 }, new[] { 768, 189 }, new[] { 668, 328 }, new[] { 697, 2 }, new[] { 389, 169 }, new[] { 550, 223 }, new[] { 514, 268 }, new[] { 579, 285 }, new[] { 419, 53 }, new[] { 318, 96 }, new[] { 335, 117 }, new[] { 729, 27 }, new[] { 694, 281 }, new[] { 349, 137 }, new[] { 545, 221 }, new[] { 679, 100 }, new[] { 382, 116 }, new[] { 707, 140 }, new[] { 62, 48 }, new[] { 664, 312 }, new[] { 499, 369 }, new[] { 547, 350 }, new[] { 509, 279 }, new[] { 778, 76 }, new[] { 186, 17 }, new[] { 741, 683 }, new[] { 635, 531 }, new[] { 441, 391 }, new[] { 493, 385 }, new[] { 354, 218 }, new[] { 304, 128 }, new[] { 651, 271 }, new[] { 693, 360 }, new[] { 613, 112 }, new[] { 798, 393 }, new[] { 743, 190 }, new[] { 115, 62 }, new[] { 725, 592 }, new[] { 525, 233 }, new[] { 621, 517 }, new[] { 327, 70 }, new[] { 501, 358 }, new[] { 504, 346 }, new[] { 787, 321 }, new[] { 94, 74 }, new[] { 729, 339 }, new[] { 50, 13 }, new[] { 603, 265 }, new[] { 163, 29 }, new[] { 781, 373 }, new[] { 586, 459 }, new[] { 797, 741 }, new[] { 624, 364 }, new[] { 411, 277 }, new[] { 360, 161 }, new[] { 690, 686 }, new[] { 746, 639 }, new[] { 553, 325 }, new[] { 631, 328 }, new[] { 388, 330 }, new[] { 619, 210 }, new[] { 573, 43 }, new[] { 559, 100 }, new[] { 210, 152 }, new[] { 378, 5 }, new[] { 776, 447 }, new[] { 615, 181 }, new[] { 365, 299 }, new[] { 708, 310 }, new[] { 718, 690 }, new[] { 268, 225 }, new[] { 639, 90 }, new[] { 318, 5 }, new[] { 196, 89 }, new[] { 361, 184 }, new[] { 762, 690 }, new[] { 772, 465 }, new[] { 729, 721 }, new[] { 541, 331 }, new[] { 567, 350 }, new[] { 269, 58 }, new[] { 656, 78 }, new[] { 579, 163 }, new[] { 711, 223 }, new[] { 282, 268 }, new[] { 760, 533 }, new[] { 404, 280 }, new[] { 473, 384 }, new[] { 94, 48 }, new[] { 340, 12 }, new[] { 727, 364 }, new[] { 264, 221 }, new[] { 591, 487 }, new[] { 514, 466 }, new[] { 305, 168 }, new[] { 372, 248 }, new[] { 639, 499 }, new[] { 560, 435 }, new[] { 541, 142 }, new[] { 462, 83 }, new[] { 594, 353 }, new[] { 618, 485 }, new[] { 95, 33 }, new[] { 602, 595 }, new[] { 605, 289 }, new[] { 715, 207 }, new[] { 448, 293 }, new[] { 752, 170 }, new[] { 641, 203 }, new[] { 532, 198 }, new[] { 608, 13 }, new[] { 707, 114 }, new[] { 744, 211 }, new[] { 110, 3 }, new[] { 298, 228 }, new[] { 622, 496 }, new[] { 286, 26 }, new[] { 683, 178 }, new[] { 706, 192 }, new[] { 751, 358 }, new[] { 486, 461 }, new[] { 561, 251 }, new[] { 466, 193 }, new[] { 342, 62 }, new[] { 221, 37 }, new[] { 731, 325 }, new[] { 205, 132 }, new[] { 518, 173 }, new[] { 502, 261 }, new[] { 640, 49 }, new[] { 541, 522 }, new[] { 747, 110 }, new[] { 756, 591 }, new[] { 124, 76 }, new[] { 639, 603 }, new[] { 765, 482 }, new[] { 388, 5 }, new[] { 34, 12 }, new[] { 514, 344 }, new[] { 495, 254 }, new[] { 770, 751 }, new[] { 730, 597 }, new[] { 708, 105 }, new[] { 683, 586 }, new[] { 528, 288 }, new[] { 386, 225 }, new[] { 287, 26 }, new[] { 649, 262 }, new[] { 753, 670 }, new[] { 789, 85 }, new[] { 632, 439 }, new[] { 570, 176 }, new[] { 672, 652 }, new[] { 445, 399 }, new[] { 400, 226 }, new[] { 655, 522 }, new[] { 469, 249 }, new[] { 557, 500 }, new[] { 275, 6 }, new[] { 397, 296 }, new[] { 725, 43 }, new[] { 605, 533 }, new[] { 425, 220 }, new[] { 637, 118 }, new[] { 628, 215 }, new[] { 654, 431 }, new[] { 697, 421 }, new[] { 512, 121 }, new[] { 237, 36 }, new[] { 151, 85 }, new[] { 574, 217 }, new[] { 320, 233 }, new[] { 492, 272 }, new[] { 552, 220 }, new[] { 739, 81 }, new[] { 712, 219 }, new[] { 612, 590 }, new[] { 410, 66 }, new[] { 548, 40 }, new[] { 320, 211 }, new[] { 381, 95 }, new[] { 633, 482 }, new[] { 742, 535 }, new[] { 704, 131 }, new[] { 682, 435 }, new[] { 508, 48 }, new[] { 435, 337 }, new[] { 534, 96 }, new[] { 663, 653 }, new[] { 283, 205 }, new[] { 715, 74 }, new[] { 484, 376 }, new[] { 585, 366 }, new[] { 635, 479 }, new[] { 753, 719 }, new[] { 793, 548 }, new[] { 396, 171 }, new[] { 156, 112 }, new[] { 575, 380 }, new[] { 717, 464 }, new[] { 612, 576 }, new[] { 569, 319 }, new[] { 736, 259 }, new[] { 406, 227 }, new[] { 711, 709 }, new[] { 793, 132 }, new[] { 528, 295 }, new[] { 592, 48 }, new[] { 731, 217 }, new[] { 408, 299 }, new[] { 373, 137 }, new[] { 786, 327 }, new[] { 791, 166 }, new[] { 712, 285 }, new[] { 772, 603 }, new[] { 723, 338 }, new[] { 531, 121 }, new[] { 572, 548 }, new[] { 786, 167 }, new[] { 670, 401 }, new[] { 724, 440 }, new[] { 280, 229 }, new[] { 497, 453 }, new[] { 265, 70 }, new[] { 733, 144 }, new[] { 689, 434 }, new[] { 504, 384 }, new[] { 93, 64 }, new[] { 563, 397 }, new[] { 550, 106 }, new[] { 224, 198 }, new[] { 372, 177 }, new[] { 249, 31 }, new[] { 667, 372 }, new[] { 263, 78 }, new[] { 783, 446 }, new[] { 791, 59 }, new[] { 438, 64 }, new[] { 630, 270 }, new[] { 216, 160 }, new[] { 704, 261 }, new[] { 674, 506 }, new[] { 704, 23 }, new[] { 378, 4 }, new[] { 784, 437 }, new[] { 196, 118 }, new[] { 681, 314 }, new[] { 698, 663 }, new[] { 397, 274 }, new[] { 499, 440 }, new[] { 737, 265 }, new[] { 697, 625 }, new[] { 139, 84 }, new[] { 440, 231 }, new[] { 453, 150 }, new[] { 266, 55 }, new[] { 377, 11 }, new[] { 728, 60 }, new[] { 431, 202 }, new[] { 268, 47 }, new[] { 763, 123 }, new[] { 347, 339 }, new[] { 470, 117 }, new[] { 466, 298 }, new[] { 344, 142 }, new[] { 584, 55 }, new[] { 417, 175 }, new[] { 439, 392 }, new[] { 548, 55 }, new[] { 714, 701 }, new[] { 643, 71 }, new[] { 357, 69 }, new[] { 649, 459 }, new[] { 789, 541 }, new[] { 626, 5 }, new[] { 752, 619 }, new[] { 711, 267 }, new[] { 639, 12 }, new[] { 750, 364 }, new[] { 620, 249 }, new[] { 769, 721 }, new[] { 636, 97 }, new[] { 233, 15 }, new[] { 171, 72 }, new[] { 488, 421 }, new[] { 251, 139 }, new[] { 750, 98 }, new[] { 199, 64 }, new[] { 768, 344 }, new[] { 759, 537 }, new[] { 435, 154 }, new[] { 425, 185 }, new[] { 336, 221 }, new[] { 418, 395 }, new[] { 390, 136 }, new[] { 618, 603 } };

	CanFinish(1, new int[][] { }).Dump();
}

int[] CanFinish(int numCourses, int[][] prerequisites)
{
	Dictionary<int, List<int>> g = new Dictionary<int, List<int>>();
	// build graph
	for (int i = 0; i < numCourses; i++)
	{
		g[i] = new List<int>();
	}
	foreach (var pair in prerequisites)
	{
		g[pair[1]].Add(pair[0]);
	}

	g.Dump();

	bool[] visited = new bool[numCourses];
	bool[] curExpl = new bool[numCourses];
	List<int> ordered = new List<int>();
	int curIndex = numCourses - 1;
	bool canSort = true;

	//run DFS
	foreach (var v in g.Keys)
	{
		if (visited[v] == false)
		{
			canSort &= TopoSort(g, v, visited, curExpl, ordered, ref curIndex);
		}
	}

	ordered.Dump();

	return canSort ? ordered.ToArray() : new int[0];
}

bool TopoSort(Dictionary<int, List<int>> g, int v, bool[] visited, bool[] curExpl, List<int> ordered, ref int curIndex)
{
	if (curExpl[v])
	{
		return false;
	}
	if (visited[v])
	{
		return true;
	}

	curExpl[v] = true;
	visited[v] = true;

	bool result = true;

	foreach (var u in g[v])
	{
		result &= TopoSort(g, u, visited, curExpl, ordered, ref curIndex);
	}

	ordered.Insert(0, v);

	curExpl[v] = false;

	return result;
}