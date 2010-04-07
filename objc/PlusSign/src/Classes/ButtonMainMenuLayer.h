//
//  ButtonLayer.h
//  plusSign
//
//  Created by Genki-Oki on 8/10/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "cocos2d.h"
#import "PSConstants.h"

#import "GameOptionScene.h"
#import "TeachMeMenuScene.h"
#import "ScoreBoardScene.h"
#import "Button.h"

@interface ButtonMainMenuLayer : Layer {

}

- (void)letsPlay: (id)sender;
- (void)teachMe: (id)sender;
- (void)topScores: (id)sender;

@end
