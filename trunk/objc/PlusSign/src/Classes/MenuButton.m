//
//  MenuButton.m
//  plusSign
//
//  Created by Genki-Oki on 10/18/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import "MenuButton.h"


@implementation MenuButton
-(id)init {
    self = [super init];
    if (self){ 
	}
    return self;
}


-(void)dealloc {
    [super dealloc];
}

+ (MenuButton *)newMenuButton:(NSString*) imagePath
{
	MenuButton *res = [self spriteWithFile:imagePath];
	//[res setIsTouchEnabled:YES];
	
	//create an Animation object to hold the frame for the walk cycle
	Animation *clickStates = [[Animation alloc] initWithName:@"clickStates" delay:0];
	[clickStates addFrameWithFilename:imagePath];
	[clickStates addFrameWithFilename:WHITEBARPATH];
	
	[res addAnimation:clickStates];
	
	return res;
}
- (CGRect) rect {
	float w = [self contentSize].width;
	float h = [self contentSize].height;
	//Utilizo 480 como tama;o de la pantalla y porque el sistema de coordenadas esta al reves!
	CGPoint point = CGPointMake([self position].x - (w/2), [self position].y - (h/2));
	
	return CGRectMake(point.x, point.y, w, h); 
}

- (BOOL)ccTouchesBegan:(NSSet *)touches withEvent:(UIEvent *)event;
{
	UITouch *touch = [touches anyObject];
	CGPoint point = [touch locationInView: [touch view]];
	
	if (CGRectContainsPoint([self rect], point)) {
		[self setDisplayFrame:@"clickStates" index:1];
	} 
	
  	return kEventHandled;
}


- (BOOL)ccTouchesEnded:(NSSet *)touches withEvent:(UIEvent *)event 
{
	UITouch *touch = [touches anyObject];
	CGPoint point = [touch locationInView: [touch view]];

	if (CGRectContainsPoint([self rect], point)) {
		[self setDisplayFrame:@"clickStates" index:0];
	} 
	
  	return kEventHandled;
}
	 
@end
