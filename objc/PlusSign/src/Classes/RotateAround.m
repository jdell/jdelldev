//
//  RotateAround.m
//  plusSign
//
//  Created by Genki-Oki on 10/17/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import "RotateAround.h"

@implementation RotateAround
+(id) actionWithDuration:(ccTime)t  centerPoint:(CGPoint)cpt spanAngle:(float)span
{	
	return [[[self alloc] initWithDuration:t 
							   centerPoint:cpt 
								 spanAngle:span] autorelease];
}

-(id) initWithDuration:(ccTime)t centerPoint:(CGPoint)cpt spanAngle:(float)span
{
	if( !(self=[super initWithDuration: t]) )
		return nil;
	
	_spanAngle = -CC_DEGREES_TO_RADIANS(span);
	_centerPt = cpt;
	return self;
}

-(void) start
{
	[super start];
	CGPoint sub = ccpSub([(CocosNode*)target position], _centerPt);
	_startAngle = ccpToAngle(sub);
	_radius = ccpLength(sub);
}

-(void) update: (ccTime) t
{	
	CGPoint sub = ccpForAngle(_startAngle + _spanAngle * t);
	[target setPosition: ccpAdd(_centerPt, ccpMult(sub, _radius))];
}
@end