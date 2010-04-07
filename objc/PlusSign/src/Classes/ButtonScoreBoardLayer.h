//
//  ButtonScoreBoardLayer.h
//  plusSign
//
//  Created by Genki-Oki on 1/4/10.
//  Copyright 2010 Genki-Oki. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "cocos2d.h"
#import "PSConstants.h"
#import "GameLayer.h"
#import "ASIFormDataRequest.h"
#import "ScoreSubmittedScoreBoardLayer.h"
#import "ScoreFailedScoreBoardLayer.h"


@interface ButtonScoreBoardLayer : Layer {
	
	Sprite *gabrielSprite;
	Animation *gabrielTalking;
	Label *words;
	
	BOOL enableLayer;
	
	ScoreSubmittedScoreBoardLayer *scoreSubmitted;
	ScoreFailedScoreBoardLayer *scoreFailed;
	
}
- (void) setMode:(tMODE) mode sprite:(Sprite *) sprite;
- (void)goToSubmitScore:(tMODE)mode;

@property(nonatomic) BOOL enableLayer;
@end
