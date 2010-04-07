//
//  RotateAround.h
//  plusSign
//
//  Created by Genki-Oki on 10/17/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "cocos2d.h"

@interface RotateAround : IntervalAction <NSCopying> 
{
	CGPoint _centerPt;
	float	_startAngle;
	float	_radius;
	float	_spanAngle;
}
+(id) actionWithDuration:(ccTime)duration
			 centerPoint:(CGPoint)cpt 
			   spanAngle:(float)spanAngle;
-(id) initWithDuration:(ccTime)duration 
		   centerPoint:(CGPoint)cpt 
			 spanAngle:(float)spanAngle;
@end
