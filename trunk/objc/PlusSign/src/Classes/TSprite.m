//
//  TSprite.m
//  plusSign
//
//  Created by Genki-Oki on 9/7/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import "TSprite.h"


@implementation TSprite


static NSMutableArray * allMySprites = nil;

+(NSMutableArray *)allMySprites {
    @synchronized(allMySprites) {
        if (allMySprites == nil)
            allMySprites = [[NSMutableArray alloc] init];
        return allMySprites;
    }
	return nil;
}

- (CGRect) rect {
	float w = [self contentSize].width;
	float h = [self contentSize].height;
	//Utilizo 480 como tama;o de la pantalla y porque el sistema de coordenadas esta al reves!
	CGPoint point = CGPointMake([self position].x - (w/2), [self position].y - (h/2));
	
	return CGRectMake(point.x, point.y, w, h); 
}

+(void)track: (TSprite *)aSprite {
    @synchronized(allMySprites) {
		NSUInteger i, count = [allMySprites count];
		for(i = 0; i < count ; i++){
			TSprite * obj = (TSprite *)[allMySprites objectAtIndex:i];
			if(obj == aSprite){
				return;
			}
		}
        [[TSprite allMySprites] addObject:aSprite];
    }
}

+(void)untrack: (TSprite *)aSprite {
    @synchronized(allMySprites) {
        [[TSprite allMySprites] removeObject:aSprite];
    }
}

+(BOOL)SomethingWasTouched:(CGPoint) pos {
	NSUInteger i, count = [allMySprites count];
	for (i = 0; i < count; i++) {
		TSprite * obj = (TSprite *)[allMySprites objectAtIndex:i];
		if (CGRectContainsPoint([obj rect], pos) && [obj GetCanTrack]) {
			return YES;
		} 
	}
	return NO;
}

+ (TSprite *) FindByTag:(int) tagVar{
	NSUInteger i, count = [allMySprites count];
	for(i = 0; i < count ; i++){
		TSprite * obj = (TSprite *)[allMySprites objectAtIndex:i];
		if([obj tag] == tagVar){
			return obj;
			
		}
	}
	return nil;	
}

+(TSprite *)FindByLocation:(CGPoint) pos {
	NSUInteger i, count = [allMySprites count];
	TSprite * obj = nil;
	for (i = 0; i < count; i++) {
		obj = (TSprite *)[allMySprites objectAtIndex:i];
		if (CGRectContainsPoint([obj rect], pos) && [obj GetCanTrack]) {
			return obj;
		} 
	}
	return obj;
}

-(id)init {
    self = [super init];
    if (self){ 
		[TSprite track:self];
		[self SetCanTrack:YES];
	}
    return self;
}

- (void) SetCanTrack:(BOOL) val{
	canTrack = val;
}
- (BOOL) GetCanTrack{
	return canTrack;
}

-(void)dealloc {
    [TSprite untrack:self];
    [super dealloc];

}
@end


