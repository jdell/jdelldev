//
//  TSprite.h
//  plusSign
//
//  Created by Genki-Oki on 9/7/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "cocos2d.h"

// Touch Sprite
@interface TSprite : Sprite {
	BOOL canTrack; //tell us if a Sprite in the Array can be tracked.
}

+(NSMutableArray *)allMySprites;
+(void)track: (TSprite *)aSprite;
+(void)untrack: (TSprite *)aSprite;
+(BOOL)SomethingWasTouched:(CGPoint) pos;
+ (TSprite *) FindByTag:(int) tagVar;
+ (TSprite *) FindBylocation:(CGPoint) pos;
- (CGRect) rect;
- (void) SetCanTrack:(BOOL) val;
- (BOOL) GetCanTrack;

@end
