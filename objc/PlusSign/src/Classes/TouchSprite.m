//
//  TouchSprite.m
//  plusSign
//
//  Created by Genki-Oki on 1/4/10.
//  Copyright 2010 Genki-Oki. All rights reserved.
//

#import "TouchSprite.h"


@implementation TouchSprite
-(BOOL)ccTouchesBegan:(NSSet *)touches withEvent:(UIEvent *)event {
    UITouch *touch = [touches anyObject];
	CGPoint location = [touch locationInView: [touch view]];
    //[self doWhateverYouWantToDo];
    //[self doItWithATouch:touch];
}
-(void)touchesMoved:(NSSet *)touches withEvent:(UIEvent *)event {
    UITouch *touch = [touches anyObject];
	CGPoint location = [touch locationInView: [touch view]];
    //[self doWhateverYouWantToDo];
    //[self doItWithATouch:touch];
}
-(void)touchesEnded:(NSSet *)touches withEvent:(UIEvent *)event {
    UITouch *touch = [touches anyObject];
	CGPoint location = [touch locationInView: [touch view]];
    //[self doWhateverYouWantToDo];
    //[self doItWithATouch:touch];
}

@end
