//
//  MenuButton.h
//  plusSign
//
//  Created by Genki-Oki on 10/18/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "cocos2d.h"


@interface MenuButton : Sprite {

}

+ (MenuButton *)newMenuButton:(NSString*) imagePath;

#define WHITEBARPATH @"whitebar.png"
@end
