//
//  ControlGameLayer.h
//  plusSign
//
//  Created by Genki-Oki on 11/7/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "cocos2d.h"
#import "Button.h"
#import "PSConstants.h"
#import "IntroScene.h"
#import "GameState.h"
#import "GivingupGameLayer.h"

@interface ControlGameLayer : Layer {
	Sprite * giveUpBtn;
	LabelAtlas *timeBoard;
	LabelAtlas *scoreBoard;
	
	BOOL enableLayer;
	
	GivingupGameLayer *givingupLayer;
}

- (void)giveUp:(id)sender;
- (void)setTimeBoard:(int)seconds;
- (void)setScoreBoard:(int)seconds;

@property(nonatomic) BOOL enableLayer;
@end
