#!/usr/bin/env python

'''
tag_generator.py
Copyright 2017 Long Qian
Contact: lqian8@jhu.edu
This script creates tags for your Jekyll blog hosted by Github page.
No plugins required.
'''

import glob
import os
import codecs

post_dir = '_posts/'
tag_dir = 'tag/'

filenames = glob.glob(post_dir + '*md')

total_tags = []
isTagsReached = False
for filename in filenames:
    f = codecs.open(filename, 'r', "utf-8")
    print ("fileName: ",filename)
    crawl = False
    # for line in f:
    #     if crawl:
    #         current_tags = line.strip().split(":")
    #         if len(current_tags) > 0:
    #             print(current_tags[0])
    #             if current_tags[0].strip() == 'tags':
    #                 isTagsReached = True
    #                 continue
    #             elif isTagsReached == True:
    #                 #total_tags.extend(current_tags[0:].strip('-'))
    #                 total_tags.append(current_tags[0].strip('-'))
    #                 crawl = False
    #                 isTagsReached = False
    #                 #break
    #     if line.strip() == '---':
    #         if not crawl:
    #             crawl = True
    #         else:
    #             crawl = False
    #             break
    for line in f:
      line = line.strip().replace('[', '').replace(']', '')
      # Find tags & cut them.
      if line.startswith('tags: '):
        total_tags += [
          t.strip() for t in line[len("tags: "):].split(',')]
        break
    f.close()
#total_tags = set(total_tags)

old_tags = glob.glob(tag_dir + '*.md')
for tag in old_tags:
    os.remove(tag)

if not os.path.exists(tag_dir):
    os.makedirs(tag_dir)


TAG_PAGE_TEMPLATE = '''---
layout: tagpage
tag: {tag}
robots: noindex
---'''

for tag in total_tags:
    tag_loc = tag.strip()
    if tag_loc:            
        tag_filename = tag_dir + tag_loc + '.md'
        f = codecs.open(tag_filename, 'w', "utf-8")
        #write_str = '---\nlayout: tagpage\ntitle: \"Tag: ' + tag + '\"\ntag: ' + tag + '\nrobots: noindex\n---\n'
        write_str = TAG_PAGE_TEMPLATE.format(tag=tag_loc)
        f.write(write_str)
        f.close()
print("Tags generated, count", total_tags.__len__())